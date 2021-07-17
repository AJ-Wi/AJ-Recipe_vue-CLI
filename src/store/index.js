import { createStore } from "vuex";

export default createStore({
  state() {
    return {
      navBarOpen: false,
    };
  },
  mutations: {
    isOpen(state) {
      state.navBarOpen = !state.navBarOpen;
    },
    isClose(state) {
      state.navBarOpen = false;
    },
  },
  actions: {
    toggleNavBar({ commit }) {
      commit("isOpen");
    },
    closeNavBar({ commit }) {
      commit("isClose");
    },
  },
  modules: {},
});
