<template>
  <div>
    <div class="intro">
      <h1>Welcome to Travelers</h1>
      <span class="explore"><router-link to="/blog">Let's explore</router-link></span>
    </div>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from "vue-class-component";
import HelloWorld from "@/components/HelloWorld.vue"; // @ is an alias to /src

@Options({})
export default class Home extends Vue {
}
</script>
<style scoped>
.intro {
  background: url("../assets/images/background.jpg") center;
  height: 85vh;
}

.intro h1 {
  position: relative;
  font-size: 72px;
  background: rgb(2, 0, 36);
  background: linear-gradient(90deg, rgba(2, 0, 36, 1) 0%, rgba(0, 212, 255, 1) 57%, rgba(9, 9, 121, 1) 93%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  animation: onEntry 0.5s;
  animation-fill-mode:forwards;
  animation-timing-function: linear;
}

@keyframes onEntry {
  0% {
    top: -10%;
    left: 50%;
    transform: translate(-50%, -50%);
  }
  25% {
    top:  5%;
    left: 50%;
    transform: translate(-50%, -50%);
  }
  50% {
    top: 15%;
    left: 50%;
    transform: translate(-50%, -50%);
  }
  75% {
    top: 25%;
    left: 50%;
    transform: translate(-50%, -50%);
  }
  100% {
    top: 35%;
    left: 50%;
    transform: translate(-50%, -50%);
  }
}

.explore {
  position: absolute;
  bottom: 35%;
  left: 50%;
  transform: translate(-50%, -50%);
  background-color: #42b983;
  width: 200px;
  height: 55px;
  line-height: 55px;
  font-family: 'Satisfy', cursive;
  border-radius: 125px;
  animation: makeVisible 0.5s;
  animation-fill-mode:forwards;
  animation-timing-function: linear;
  animation-delay: 0.5s;
  opacity: 0;

}

.explore a {
  text-decoration: none;
  font-size: 26px;
  color: white;
  letter-spacing: 1px;
}

@keyframes makeVisible {
  0% {
    opacity: 0;
  }
  25% {
    opacity: 0.2;
  }
  50% {
    opacity: 0.5;
  }
  75% {
    opacity: 0.7;
  }
  100% {
    opacity: 1;
  }
}
</style>
