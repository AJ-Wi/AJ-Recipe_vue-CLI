<template>
  <header id="site-header">
    <nav id="site-header_nav">
      <h1>
        <router-link to="/">Recipe Medico</router-link>
      </h1>
      <BtnMenu />
    </nav>
  </header>
</template>

<script>
import BtnMenu from "@/components/BtnMenu.vue";
export default {
  components: {
    BtnMenu,
  },
};
</script>

<style>
#site-header {
  background-color: var(--primary-color);
  padding: 0 15px;
  display: flex;
  position: sticky;
  top: 0;
}

#site-header::after {
  content: "";
  position: absolute;
  top: calc(60px - 4px);
  left: 0;
  width: 100%;
  height: 4px;
  background: linear-gradient(
    to right,
    var(--primary-color),
    var(--second-color)
  );
}

#site-header_nav {
  width: 100%;
  display: grid;
  grid-template-columns: 1fr 40px;
  align-content: center;
}
</style>
