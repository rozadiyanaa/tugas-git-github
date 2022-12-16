<template>
  <div id="app">
    <img src="./assets/logo-unri.png" height="75" width="300">
    <web-toolbar></web-toolbar>
    <web-footer></web-footer>
    <router-view/>
  </div>
</template>

<script>
import WebFooter from './components/WebFooter'
import WebToolbar from './components/WebToolbar'

export default {
  name: 'App',
  components:{WebFooter,WebToolbar}
}
</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}


</style>
