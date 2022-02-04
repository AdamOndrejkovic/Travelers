<template>
  <div>
    <div class="intro">
      <h1>Welcome to Travelers</h1>
    </div>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from "vue-class-component";
import HelloWorld from "@/components/HelloWorld.vue"; // @ is an alias to /src

@Options({
  components: {
    HelloWorld,
  },
})
export default class Home extends Vue {}
</script>
<style scoped>
.intro {
  background: url("../assets/images/background.jpg") center;
  height: 50vh;
  position: relative;
}

.intro h1 {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  color: white;
  font-size: 32px;
}
</style>
