<template>
  <button class="Btn-Primary">
    <img :src="rute" :alt="title" />
    {{ title }}
  </button>
</template>

<script>
export default {
  props: {
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
.Btn-Primary {
  border: 3px solid var(--primary-color);
  border-radius: 3px;
  background-color: transparent;
  display: grid;
  place-items: center;
}

.Btn-Primary img {
  width: 40%;
}
</style>
