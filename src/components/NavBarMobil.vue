<template>
  <nav class="navbar-mobil">
    <NavItems :rute="require(`@/assets/enfermedades.svg`)" title="Enfermedad" />
    <NavItems :rute="require(`@/assets/dietas.svg`)" title="Dietas" />
    <NavItems :rute="require(`@/assets/terapias.svg`)" title="Terapias" />
    <NavItems :rute="require(`@/assets/consejos.svg`)" title="Consejos" />
  </nav>
</template>

<script>
import NavItems from "@/components/NavItems.vue";

export default {
  name: "NavBarMobil",
  components: {
    NavItems,
  },
};
</script>

<style>
.navbar-mobil {
  position: fixed;
  bottom: 0;
  display: flex;
  height: 60px;
  width: 100%;
  justify-content: space-around;
  border-top: 1px solid var(--second-color);
  background-color: var(--primary-color);
}

.navbar-mobil .nav-item {
  grid-template-columns: 60px;
}

.navbar-mobil .nav-img {
  width: 60%;
}

.navbar-mobil .nav-title {
  font-size: 0.7rem;
  text-align: center;
}

@media (min-width: 959px) {
  .navbar-mobil {
    display: none;
  }
}
</style>
