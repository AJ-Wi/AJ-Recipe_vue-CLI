<template>
  <NavBar />
  <main>
    <Header />
    <router-view />
  </main>
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
  --first-alpha-color: rgba(0, 255, 0, 0.75);
  --second-color: #1464e6;
  --second-alpha-color: rgba(20, 100, 230, 0.75);
  --third-color: #501464;
  --third-alpha-color: rgba(80, 20, 100, 0.75);
  --bg-color: #fff;
  --header-height: 4rem;
  --max-width: 1200px;
  --font: "Raleway", sans-serif;
  --font-size: 16px;
}

#app {
  display: flex;
}

main {
  margin: 3rem 0 0 0;
  width: 100%;
}

@media (min-width: 768px) {
  main {
    margin-left: -3rem;
  }
}
</style>
