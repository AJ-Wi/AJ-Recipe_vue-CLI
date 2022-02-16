<template>
  <nav class="nav-bar" :class="{ 'is-open': navBarOpen }">
    <NavItems
      data-order="1"
      @click="isClose"
      :rute="require(`@/assets/enfermedades.svg`)"
      title="Enfermedades"
    />
    <NavItems
      @click="isClose"
      :rute="require(`@/assets/dietas2.svg`)"
      title="Dietas"
    />
    <NavItems
      @click="isClose"
      :rute="require(`@/assets/terapias.svg`)"
      title="Terapias"
    />
    <NavItems
      @click="isClose"
      :rute="require(`@/assets/consejos.svg`)"
      title="Consejos"
    />
    <NavItems
      @click="isClose"
      :rute="require(`@/assets/medico.svg`)"
      title="Usuario"
      class="nav-config"
    />
    <NavItems
      @click="isClose"
      :rute="require(`@/assets/config.svg`)"
      title="Configuración"
      class="nav-config"
    />
  </nav>
</template>

<script>
import { mapActions, mapState } from "vuex";
import NavItems from "@/components/NavItems.vue";

export default {
  name: "NavBarDesktop",
  components: {
    NavItems,
  },
  computed: {
    ...mapState(["navBarOpen"]),
  },
  methods: {
    ...mapActions(["closeNavBar"]),
    isClose() {
      this.closeNavBar();
    },
  },
};
</script>

<style>
.nav-bar {
  display: flex;
  width: 100%;
  height: 3.5rem;
  background-color: var(--primary-color);
  justify-content: space-around;
  position: fixed;
  bottom: 0;
  z-index: 999;
}

.nav-config {
  display: none;
}

@media (min-width: 768px) {
  .nav-bar {
    flex-direction: column;
    justify-content: flex-start;
    width: 12rem;
    height: 100vh;
    transition: all 0.5s ease;
    position: sticky;
    top: 0px;
    left: 0px;
  }

  .nav-config {
    display: block;
  }
}
</style>
