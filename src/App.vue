<template>
  <Header />
  <router-view />
</template>

<script>
import Header from "@/components/Header.vue";
export default {
  components: {
    Header,
  },
};
</script>

<style>
:root {
  /*********** Colors ************/
  --primary-color: #008afc;
  --second-color: #67bd31;
  --bg: #fbfbfe;
  --bg-container: var(--bg);
  --bg-button: var(--primary-color);
  --bg-list: var(--primary-color);
  --border-list: var(--second-color);
  --bg-border: #d2d2d2;
  --text-color: #000000;

  /********** sizes **************/
  --container-width: 1200px;
  --font-size: 16px;
  --main-font: Avenir, Helvetica, Arial, sans-serif;
}

[data-dark="true"] {
  /********* Dark Color **********/
  --primary-color: #898989;
  --second-color: #fbfbfe;
  --bg: #192229;
  --bg-container: #212e36;
  --bg-button: #094977;
  --bg-list: #008afc;
  --border-list: #67bd31;
  --bg-border: #2a3b47;
  --text-color: var(--second-color);
}

/************ reset **************/
html {
  box-sizing: border-box;
}

*,
*::before,
*::after {
  box-sizing: inherit;
  margin: 0;
  padding: 0;
}

body {
  overflow-x: hidden;
  background-color: var(--bg);
  color: var(--text-color);
  font-size: var(--font-size);
  font-family: var(--main-font);
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

#app {
  display: grid;
  grid-template-areas:
    "site-header"
    "site-content";
}
</style>
