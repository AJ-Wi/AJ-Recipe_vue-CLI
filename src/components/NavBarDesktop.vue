<template>
  <nav class="navbar-desktop" :class="{ 'is-open': navBarOpen }">
    <section class="nav-main">
      <NavItems
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
    </section>
    <section class="nav-config">
      <NavItems
        @click="isClose"
        :rute="require(`@/assets/medico.svg`)"
        title="Usuario"
      />
      <NavItems
        @click="isClose"
        :rute="require(`@/assets/config.svg`)"
        title="Configuración"
      />
    </section>
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
.navbar-desktop {
  display: none;
}

@media (min-width: 959px) {
  .navbar-desktop {
    position: sticky;
    top: 60px;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    width: 220px;
    margin-left: -160px;
    min-height: calc(100vh - 60px);
    background-color: var(--primary-color);
    border-top: 1px solid var(--second-color);
    border-right: 1px solid var(--second-color);
    transition: all 0.5s;
  }

  .nav-item {
    grid-template-columns: 160px 60px;
  }

  .nav-item .nav-title {
    grid-column: 1 / 2;
    grid-row: 1 / 2;
    text-align: end;
  }

  .navbar-desktop.is-open {
    margin-left: 0;
  }
}
</style>
