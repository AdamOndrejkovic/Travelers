<template>
  <section>
    <h2>{{ article.title }}</h2>
    <p>{{ article.mainText }}</p>
    <p>{{ article.subText }}</p>
    <p>{{ article.image }}</p>
  </section>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import { Article } from "../../types/types";

export default defineComponent({
  props: {
    article: {
      type: Object as () => Article,
      required: true,
    },
  },
  setup() {
    const info = "123";

    return {
      info,
    };
  },
});
</script>

<style scoped></style>
