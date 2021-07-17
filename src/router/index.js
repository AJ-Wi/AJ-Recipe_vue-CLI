import { createRouter, createWebHistory } from "vue-router";

const routes = [
  {
    path: "/",
    name: "PatientHistory",
    component: () => import("../views/PatientHistory.vue"),
  },
  {
    path: "/about",
    name: "About",
    component: () => import("../views/About.vue"),
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
