<template>
  <nav class="nav-bar" :class="{ close: close }">
    <section class="nav-main">
      <NavItems @click="isClose" title="menu" type="menu" />
      <NavItems title="Enfermedades" class="is-active" />
      <NavItems title="Dietas" />
      <NavItems title="Terapias" />
      <NavItems title="Consejos" />
    </section>
    <section class="nav-config">
      <NavItems title="Usuario" />
      <NavItems title="Configuración" />
    </section>
  </nav>
</template>

<script>
import NavItems from "@/components/NavItems.vue";

export default {
  name: "NavBar",
  components: {
    NavItems,
  },
  data() {
    return {
      close: {
        type: Boolean,
        default: true,
      },
    };
  },
  methods: {
    isClose() {
      this.close = !this.close;
    },
  },
};
</script>

<style>
.nav-bar {
  display: flex;
  width: 100%;
  height: 3.5rem;
  background-color: var(--second-color);
  position: fixed;
  bottom: 0;
  z-index: 999;
}

.nav-bar .nav-main {
  display: flex;
  width: 100%;
  justify-content: space-around;
}

.nav-bar .nav-btn {
  display: none;
}

.nav-config {
  display: none;
}

@media (min-width: 768px) {
  .nav-bar {
    flex-direction: column;
    justify-content: space-between;
    width: 12rem;
    height: 100vh;
    transition: all 0.5s ease;
    position: sticky;
    top: 0px;
    left: 0px;
  }

  .nav-bar .nav-main {
    display: block;
  }

  .nav-bar .nav-btn {
    display: block;
    padding: 0.25rem;
  }

  .nav-config {
    display: block;
  }

  .nav-bar.close {
    width: 3rem;
  }

  .nav-bar.close svg {
    fill: var(--first-color);
  }

  .nav-bar.close .nav-title {
    opacity: 0;
  }

  .nav-bar.close .nav-item.is-active svg {
    fill: var(--second-color);
  }

  .nav-bar.close .nav-item:hover {
    border-left: 1px solid transparent;
  }
}
</style>
