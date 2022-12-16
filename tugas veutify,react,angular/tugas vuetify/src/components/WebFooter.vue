<template>
    <v-footer
        dark
        height="auto"
        id="footer"
    >
        <v-card
            class="flex"
            flat
            tile
        >
        <v-card-title id="card" class="green darken-4">
           <strong class="subheading">Get conected with us on social networks!</strong>
           <v-spacer></v-spacer>
           <v-btn
            v-for="icon in icons"
            :key="icon"
            class="mx-3"
            dark
            icon
            >
                <v-icon size="24px">{{ icon }}</v-icon>
            </v-btn>
        </v-card-title>

        <v-card-actions class="grey darken-3 justify-center">
            ©2018 - <strong>Universitas Riau</strong>
        </v-card-actions>
        </v-card>
    </v-footer>
</template>

<script>
    export default {
        data: () => ({
            icons: [
                'mdi-facebook',
                'mdi-twitter',
                'mdi-google-plus',
                'mdi-linkedin',
                'mdi-instagram'
            ]
        })
    }
</script>
<style>
#footer {
    position: absolute;
    bottom: 0;
    width: 100%;
    background-color: darkgreen;
}
#card {
    background-color: darkgreen;
}
</style>