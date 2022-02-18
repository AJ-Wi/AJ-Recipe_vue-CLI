<template>
  <header class="header-site">
    <section class="header-title">
      <h1>Recipe Medico</h1>
    </section>
    <section class="header-img">
      <img
        src="https://assets.codepen.io/5993985/internal/avatars/users/default.png?format=auto&version=1642194704&width=300&height=300"
        alt="user"
      />
    </section>
  </header>
</template>

<style>
.header-site {
  position: fixed;
  top: 0px;
  right: 0px;
  height: 3rem;
  width: 100%;
  z-index: 1;
  color: var(--first-color);
  padding: 0.3rem;
  display: flex;
  justify-content: space-between;
  gap: 20px;
  background-color: var(--second-color);
}

.header-site .header-title {
  display: flex;
  align-items: center;
}

.header-site img {
  width: auto;
  height: 100%;
  border-radius: 50%;
}

@media (min-width: 768px) {
  .header-site {
    justify-content: center;
  }

  .header-site .header-img {
    display: none;
  }
}
</style>
