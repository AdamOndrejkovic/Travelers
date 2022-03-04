<template>
  <section class="flex flex-col w-full">
    <div v-if="loading">
      <p>Loading</p>
    </div>
    <div v-else>
      <ul>
        <li v-for="article in blogArticles" :key="article.id" @click="redirectToArticle(article)">

        </li>
      </ul>
    </div>
  </section>
</template>

<script lang="ts">
import {defineComponent, reactive, ref, watch} from "vue";
import api from "@/services/api";
import { Article } from "../../types/types"
import BlogArticle from "@/components/blog/BlogArticle.vue";
import router from "@/router";

export default defineComponent({
  components: {
    BlogArticle,
  },

  setup() {
    let blogArticles = ref<Article[]>([])
    const loading = ref<boolean>(true)

    const getArticles = async () => {
      blogArticles.value = await api.getAllArticles()
    }
    getArticles()

    watch(
        () => blogArticles.value,
        () => {
          loading.value = false
        }
    )

    const redirectToArticle = (article: Article) => {
      router.push({ path: `/article/${article.id}`})
    }

    return{
      loading,
      blogArticles,
      redirectToArticle,
    }



  }

})
</script>

<style scoped>

</style>
