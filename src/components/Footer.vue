<template>
  <footer id="site-footer">
    <nav id="site-footer_nav">
      <router-link to="/">
        <img src="@/assets/medico.png" alt="medico" />
      </router-link>
      <h6>
        <router-link to="/"> Dr. Augusto González </router-link>
      </h6>
      <h6>
        <router-link to="/"> Clínica Guarenas </router-link>
      </h6>
      <router-link to="/">
        <img src="@/assets/logo.png" alt="logo" />
      </router-link>
    </nav>
  </footer>
</template>

<style>
#site-footer {
  padding: 0 15px;
  display: flex;
  position: relative;
}

#site-footer::after {
  content: "";
  position: absolute;
  bottom: calc(60px - 4px);
  left: 0;
  width: 100%;
  height: 4px;
  background: linear-gradient(
    to right,
    var(--primary-color),
    var(--second-color)
  );
}

#site-footer_nav {
  width: 100%;
  display: grid;
  grid-template-columns: 30px 1fr 1fr 30px;
  align-items: center;
}

#site-footer_nav a {
  color: var(--text-color);
}

#site-footer_nav h6:nth-child(3) {
  justify-self: end;
}
</style>
