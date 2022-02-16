<template>
  <router-link v-if="type === 'items'" :to="link" class="nav-item">
    <div :id="id" class="nav-icon">
      <svg viewBox="0 0 48 48">
        <path :d="iconLoad()" />
      </svg>
    </div>
    <span class="nav-title">{{ title }}</span>
  </router-link>
  <div v-else class="nav-btn">
    <div id="menu" class="nav-icon">
      <svg viewBox="0 0 48 48">
        <path :d="iconLoad()" />
      </svg>
    </div>
    <span class="nav-title"></span>
  </div>
</template>

<script>
import Icons from "@/assets/iconsPack.js";

export default {
  props: {
    link: {
      type: String,
      default: "/",
    },
    title: {
      type: String,
      default: "Enfermedades",
    },
    type: {
      type: String,
      default: "items",
    },
  },
  methods: {
    iconLoad() {
      return Icons[this.title];
    },
  },
};
</script>

<style scoped>
.nav-item {
  text-decoration: none;
  padding: 0.25rem;
  text-align: center;
}

.nav-icon {
  height: 2rem;
}

svg {
  width: 2rem;
  height: 2rem;
  fill: var(--first-color);
  cursor: pointer;
}

.nav-title {
  color: var(--first-color);
  font-size: 0.6rem;
}

.nav-item.is-active {
  background-color: var(--first-color);
}

.nav-item.is-active svg {
  fill: var(--second-color);
}

.nav-item.is-active .nav-title {
  color: var(--second-color);
}

.nav-item:hover {
  background-color: var(--first-color);
}

.nav-item:hover svg {
  fill: var(--second-color);
}

.nav-item:hover .nav-title {
  color: var(--second-color);
}

@media (min-width: 768px) {
  .nav-item {
    overflow: hidden;
    display: flex;
    align-items: center;
    text-align: left;
    gap: 1rem;
    transition: transform 1s ease;
  }

  .nav-icon {
    height: 2.5rem;
  }

  svg {
    width: 2.5rem;
    height: 2.5rem;
    transition: fill 0.5s ease;
  }

  .nav-title {
    width: calc(12rem - 3rem);
    font-size: 1rem;
    transition: all 0.5s ease;
  }
}
</style>
