/**
 * Registers all of the content components representing pages and blocks. They
 * need to be globally registered because they are dynamically rendered by the
 * component selectors (`PageComponentSelector` and `BlockComponentSelector`).
 */

import Vue from 'vue';
import '@/Styles/Main.less';

import router from '@/Scripts/router';
import store from '@/Scripts/store';
import { sync } from 'vuex-router-sync';
sync(store, router);

// `epiMessages` does not export anything but registers the `contentSaved`
// and `epiReady` message handlers that updates the vuex store.
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/import#Import_a_module_for_its_side_effects_only
import '@/Scripts/epiMessages';

//// generate svg sprite from all files in /Assets/Images/SVG
//const files = require.context('@/Images/SVG', false, /.*\.svg$/);
//files.keys().forEach(files);

// Episerver helpers
import EpiEdit from '@/Scripts/directives/epiEdit';
Vue.directive('epi-edit', EpiEdit);

import LandingPage from '@/Scripts/components/pages/HomePage.vue';
// Views
import DefaultPage from '@/Scripts/components/DefaultPage.vue';

// Blocks

// Media

// Pages
Vue.component('HomePage', LandingPage);
// Views
Vue.component('DefaultPage', DefaultPage);

/* eslint-disable-next-line no-unused-vars */
let App = new Vue({
    el: '#App',
    store,
    router
});
