<template>
  <router-link :to="link" class="nav-item">
    <img :src="rute" :alt="title" class="nav-img" />
    <h3 class="nav-title">{{ title }}</h3>
  </router-link>
</template>

<script>
export default {
  props: {
    link: {
      type: String,
      default: "/",
    },
    rute: {
      type: String,
    },
    title: {
      type: String,
    },
  },
};
</script>

<style>
.nav-item {
  display: grid;
  height: 60px;
  align-content: center;
}

.nav-item .nav-img {
  width: 70%;
  justify-self: center;
}

.nav-item .nav-title {
  align-self: center;
}
</style>
