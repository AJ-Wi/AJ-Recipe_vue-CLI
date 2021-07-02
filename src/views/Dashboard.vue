<template>
  <div id="dashboard">
    <NavButton :rute="require(`@/assets/paciente.png`)" title="Consulta" />
    <NavButton :rute="require(`@/assets/historial.png`)" title="Historias" />
    <NavButton
      :rute="require(`@/assets/enfermedades.png`)"
      title="Enfermedades"
    />
    <NavButton :rute="require(`@/assets/dietas.png`)" title="Dietas" />
    <NavButton :rute="require(`@/assets/terapias.png`)" title="Terapias" />
    <NavButton :rute="require(`@/assets/consejos.png`)" title="Consejos" />
  </div>
</template>

<script>
// @ is an alias to /src
import NavButton from "@/components/NavButton.vue";

export default {
  name: "Dashboard",
  components: {
    NavButton,
  },
};
</script>

<style>
#dashboard {
  display: grid;
  grid-template-columns: 1fr 1fr;
  padding: 15px;
  gap: 15px;
}

@media (min-width: 419px) {
  #dashboard {
    grid-template-columns: repeat(3, 1fr);
  }
}
</style>
