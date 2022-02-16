<template>
  <router-link :to="link" class="nav-item">
    <div :id="id" class="nav-icon">
      <svg viewBox="0 0 48 48">
        <path :id="icon" :d="iconLoad()" />
      </svg>
    </div>
    <span class="nav-title">{{ title }}</span>
  </router-link>
</template>

<script>
import Icons from "@/assets/iconsPack.js";

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
    icon: {
      type: String,
      default: "service",
    },
  },
  methods: {
    iconLoad() {
      return Icons[this.icon];
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
  fill: var(--second-color);
  cursor: pointer;
}

.nav-title {
  color: var(--second-color);
  font-size: 0.6rem;
}

.nav-item.is-active {
  background-color: var(--second-color);
}

.nav-item.is-active svg {
  fill: var(--second-color);
}

.nav-item.is-active .nav-title {
  color: var(--second-color);
}

.nav-item:hover {
  background-color: var(--second-color);
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
