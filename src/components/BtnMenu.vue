<template>
  <button
    class="hamburger"
    :class="{ 'is-active': active }"
    type="button"
    @click="active = !active"
  >
    <span class="hamburger-box">
      <span class="hamburger-inner"></span>
    </span>
  </button>
</template>

<script>
export default {
  name: "BtnMenu",
  data() {
    return {
      active: false,
    };
  },
};
</script>

<style scoped>
.hamburger {
  cursor: pointer;
  background-color: transparent;
  border: 0;
}

.hamburger:hover {
  opacity: 0.7;
}

.hamburger-box {
  position: relative;
}

.hamburger-inner {
  display: block;
  top: 50%;
  margin-top: -2px;
  background-color: var(--second-color);
  transition-duration: 0.2s;
}

.hamburger-inner,
.hamburger-inner::before,
.hamburger-inner::after {
  width: 40px;
  height: 4px;
  border-radius: 4px;
  position: absolute;
}

.hamburger-inner::before,
.hamburger-inner::after {
  content: "";
  display: block;
  background-color: inherit;
}

.hamburger-inner::before {
  top: -10px;
}

.hamburger-inner::after {
  bottom: -10px;
}

/*********** Active State ***************/

.hamburger.is-active .hamburger-inner {
  transform: rotate(765deg);
  background-color: var(--second-color);
}

.hamburger.is-active .hamburger-inner::before {
  opacity: 0;
}

.hamburger.is-active .hamburger-inner::after {
  bottom: 0;
  transform: rotate(90deg);
}
</style>
