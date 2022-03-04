<template>
  <section>
    <h1>Blog</h1>
    <blog-list></blog-list>
  </section>
</template>

<script>
import BlogList from "@/components/blog/BlogList";
export default {
  name: "Blog",
  components: {BlogList},
};
</script>

<style scoped></style>
