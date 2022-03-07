<template>
  <div id="nav">
    <router-link to="/" class="logo"><img src="../src/assets/images/logo.jpg" alt=""></router-link>
    <router-link to="/">Home</router-link> |
    <router-link to="/about">About</router-link> |
    <router-link to="/blog">Blog</router-link> |
    <router-link to="/contact">Contact</router-link> |
  </div>
  <router-view />
</template>
<script lang="ts">
</script>
<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  overflow: hidden;
  padding: 25px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}

.logo {
  position: absolute;
  left: -10%;
  top: 0%;
}

.logo img {
  padding-left: 25px;
  height: 86px;
}
</style>
