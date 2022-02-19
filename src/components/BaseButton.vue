<template>
  <div class="btn">
    <img :src="img" alt="button" />
    <p>
      {{ title }}
    </p>
  </div>
</template>

<script>
export default {
  props: {
    img: {
      type: String,
    },
    title: {
      type: String,
    },
  },
};
</script>

<style scoped>
.btn {
  width: 100%;
  min-width: 30px;
  height: 30px;
  background-color: var(--blue-soft);
  border-radius: 3px;
  color: white;
  display: flex;
  padding: 5px;
}

.btn img {
  width: 30px;
}

.btn p {
  display: none;
}

@media (min-width: 768px) {
  .btn {
    min-width: 150px;
  }
  .btn p {
    display: block;
    align-self: flex-end;
  }
}
</style>
