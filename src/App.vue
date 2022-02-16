<template>
  <Header />
  <NavBar />
  <router-view />
</template>

<script>
import Header from "@/components/Header.vue";
import NavBar from "@/components/NavBar.vue";

export default {
  components: {
    Header,
    NavBar,
  },
  computed: {
    resolvedDate() {
      let formatDate = new Date(new Date()).toLocaleDateString(undefined, {
        weekday: "long",
        year: "numeric",
        month: "long",
        day: "numeric",
      });
      return formatDate;
    },
  },
};
</script>

<style>
:root {
  /*********** Colors ************/
  --first-color: #00ff00;
  --second-color: #1464e6;
  --blue-soft: #32c8e6;
  --bg: #fbfbfe;
  --bg-button: #32c8e6;
  --text-color: #000000;
  --border-color: #898989;

  /********** sizes **************/
  --height-header: 60px;
  --container-width: 1200px;
  --font-size: 16px;
  --main-font: Avenir, Helvetica, Arial, sans-serif;
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

a {
  text-decoration: none;
  color: var(--second-color);
}

img {
  width: 100%;
}

#app {
  min-height: 100vh;
}
</style>
