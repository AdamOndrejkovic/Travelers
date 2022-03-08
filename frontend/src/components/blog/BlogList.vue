<template>
  <section class="flex flex-col w-full">
    <div v-if="loading">
      <p>Loading</p>
    </div>
    <div v-else>
      <div class="grid-container">
        <div
          v-for="article in blogArticles"
          :key="article.id"
          @click="redirectToArticle(article)"
          class="grid-item"
        >
          <img :src="article.image" alt="Article Image">
          <h3>{{ article.title }}</h3>
          <span>Read more</span>

        </div>
      </div>
    </div>
  </section>
</template>

<script lang="ts">
import { defineComponent, reactive, ref, watch } from "vue";
import api from "@/services/api";
import { Article } from "../../types/types";
import router from "@/router";

export default defineComponent({
  components: {
  },

  setup() {
    let blogArticles = ref<Article[]>([]);
    const loading = ref<boolean>(true);

    const getArticles = async () => {
      blogArticles.value = await api.getAllArticles();
    };
    getArticles();

    watch(
      () => blogArticles.value,
      () => {
        loading.value = false;
      }
    );

    const redirectToArticle = (article: Article) => {
      router.push({ path: `/article/${article.id}` });
    };

    return {
      loading,
      blogArticles,
      redirectToArticle,
    };
  },
});
</script>

<style scoped>
.grid-container {
  display: grid;
  gap: 50px;
  grid-template-columns: auto auto auto;
  padding: 10px;
  width: 90%;
  margin: auto;
}

.grid-item {
  background-color: rgba(255, 255, 255, 0.8);
  border: deepskyblue dotted 2px;
  border-radius: 25px;
  padding: 20px;
  text-align: center;
  width: 33.3%;
  height: 250px;
}

.grid-item img {
  background: green;
  width: 80%;
  height: 60%;
}

.grid-item h3 {
  padding: 8px;
  width: 80%;
  overflow: hidden;
  margin: 15px auto;
}

.grid-item span {
  background: #f66947;
  padding: 5px 10px;
  font-family: 'Satisfy', cursive;
  color: white;
  border-radius: 25px;
}

.grid-item span:hover {
  background: #ffffff;
  border: #f66947 2px dotted;
  color: #f66947;
}
</style>
