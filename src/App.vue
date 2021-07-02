<template>
  <Header />
  <section class="banner">
    <img src="@/assets/portada.jpg" alt="portada" />
  </section>
  <section class="message">
    <h3>Lunes 25 de Enero del 2021</h3>
    <h2>Hoy tiene 1 Cita</h2>
  </section>
  <router-view />
  <Footer />
</template>

<script>
import Header from "@/components/Header.vue";
import Footer from "@/components/Footer.vue";

export default {
  components: {
    Header,
    Footer,
  },
};
</script>

<style>
:root {
  /*********** Colors ************/
  --primary-color: #1464e6;
  --second-color: #00ff00;
  --bg: #fbfbfe;
  --bg-container: var(--bg);
  --bg-button: #32c8e6;
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
  min-height: 100vh;
  grid-template-columns: 1fr;
  grid-template-rows: 60px 140px 60px 1fr 60px;
}

a {
  text-decoration: none;
  color: var(--second-color);
}

img {
  width: 100%;
}

.banner img {
  height: 140px;
  object-fit: cover;
}

.message {
  background-color: var(--bg-button);
  display: grid;
  place-items: center;
}
</style>
