<!--
    Landing page for the site.
    When the BuyTicketBlock modal is shown, the OPE overlays in the Hero are turned off through the `showModal` data property.

    View for Models/Pages/LandingPage.cs
-->

<template>
    <div class="HomePage" scoped>
        <Hero :title="model.title" :subtitle="model.subtitle" :heroimage="model.heroImage" />

        <main class="Page-container">
            <div v-epi-edit="'MainContentArea'">
                <ContentArea :model="model.mainContentArea"></ContentArea>
            </div>
        </main>

        <footer>
            <div v-epi-edit="'FooterContentArea'">
                <ContentArea :model="model.footerContentArea"></ContentArea>
            </div>
            <div class="FooterBottom">
                <h6>&copy; PoC 2022</h6>
            </div>
        </footer>
    </div>
</template>

<script>
import ContentArea from '@/Scripts/components/ContentArea.vue';
import Hero from '@/Scripts/components/widgets/Hero.vue';
import { SHOW_MODAL } from '@/Scripts/store/modules/appContext';
import { mapMutations } from 'vuex';

export default {
    components: {
        ContentArea,
        Hero,
    },
    props: ['model'],
    methods: mapMutations({
        showModal: SHOW_MODAL
    })
};
</script>

<!--<style lang="less">
    @import '../../../Styles/Common/variables.less';

    main, footer {
        overflow: hidden;
        width: 100%;
    }

    footer .ContentArea.Grid--gutterA {
        // Disable gutters because we want this content area to be full width.
        margin: 0;
    }

    .landing-page-button {
        position: absolute;
        left: 50%;
        transform: translateX(-50%);
        margin-top: 1em;
    }

    .buy-ticket-button {
        margin-top: 11px;
    }
</style>-->
