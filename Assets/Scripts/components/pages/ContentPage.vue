<!--
    Content page for the site.

    View for Models/Pages/ContentPage.cs
-->

<template>
    <div class="ContentPage" scoped>
        <main class="Page-container">
            <h1 v-epi-edit="'Title'" v-html="model.title"></h1>
            <p v-epi-edit="'Description'" v-html="model.description"></p>

            <div v-epi-edit="'MainContentArea'">
                <ContentArea :model="model.mainContentArea"></ContentArea>
            </div>
        </main>

        <footer>
            <div class="FooterBottom">
                <h6>&copy; PoC 2022</h6>
            </div>
        </footer>
    </div>
</template>

<script>
import ContentArea from '@/Scripts/components/ContentArea.vue';
import { SHOW_MODAL } from '@/Scripts/store/modules/appContext';
import { mapMutations } from 'vuex';

export default {
    components: {
        ContentArea
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
