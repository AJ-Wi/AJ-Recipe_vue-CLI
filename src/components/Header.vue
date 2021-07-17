<template>
  <header class="site-header">
    <nav class="site-navbar">
      <h1 class="site-title">
        <router-link to="/">Recipe Medico</router-link>
      </h1>
      <div
        @click="isOpen"
        class="site-hamburger"
        :class="{ 'is-open': navBarOpen }"
      >
        <i class="fas fa-bars" id="menu-bar"></i>
      </div>
    </nav>
  </header>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  computed: {
    ...mapState(["navBarOpen"]),
  },
  methods: {
    ...mapActions(["toggleNavBar"]),
    isOpen() {
      this.toggleNavBar();
    },
  },
};
</script>

<style>
.site-header {
  background-color: var(--primary-color);
  position: sticky;
  top: 0;
}

.site-header::after {
  content: "";
  position: absolute;
  top: calc(var(--height-header) - 4px);
  left: 0;
  width: 100%;
  height: 4px;
  background: linear-gradient(
    to right,
    var(--primary-color),
    var(--second-color)
  );
}

.site-navbar {
  display: grid;
  height: var(--height-header);
  grid-template-columns: repeat(8, 1fr);
}

.site-title {
  grid-column: 1 / 3;
  min-width: 150px;
  font-size: 1.3rem;
  align-self: center;
  margin-left: 1rem;
}

.site-hamburger {
  grid-column: 8 / 9;
  justify-self: flex-end;
  width: 60px;
  display: flex;
  justify-content: center;
  align-items: center;
  color: var(--second-color);
  font-size: 2em;
  cursor: pointer;
  z-index: 1;
  transition: all 0.5s;
}

@media (min-width: 738px) {
  .site-title {
    font-size: 1.5rem;
  }
}

@media (min-width: 959px) {
  .site-title {
    grid-column: 4 / 6;
    justify-self: center;
  }

  .site-hamburger {
    grid-column: 1 / 3;
    grid-row: 1 / 2;
    justify-self: flex-start;
    border-right: 1px solid var(--second-color);
  }

  .site-hamburger.is-open {
    width: 220px;
    justify-content: flex-end;
    padding-right: 1rem;
  }
}
</style>
