<template>
    <v-toolbar id="toolbar" color="green darken-4" dark>
        <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
        <div>
            <v-btn text>Home</v-btn>
            <v-btn text>Profile</v-btn>
            <v-btn text>Unit/Lembaga</v-btn>
            <v-btn text>Akademik</v-btn>
            <v-btn text>Dokumen</v-btn>
            <v-btn text>Gallery</v-btn>
            <v-btn text>Peta</v-btn>
            <v-btn text>Video Profil</v-btn>
            <router-Link to="/login">
                <v-btn text>Kontak</v-btn>
            </router-Link>
        </div>
        <div class="hidden-sm-and-down">
        <v-navigation-drawer
            v-model="drawer"
            absolute
            bottom
            temporary
            height="800px">
            <v-List class="pa-1">
                <v-list-item avatar>
                    <v-list-item-avatar>
                        <img src="https://randomuser.me/api/portraits/men/85.jpg">
                </v-list-item-avatar>

                <v-list-item-content>
                    <v-list-item-title>John Leider</v-list-item-title>
                </v-list-item-content>
                </v-list-item>
            </v-List>
            <v-list class="pt-0" dense>
                <v-divider></v-divider>

                <v-list-item
                    v-for="item in items"
                    :key="item.title">
                    <v-list-item-action>
                        <v-icon>{{ item.icon }}</v-icon>
                    </v-list-item-action>

                    <v-list-item-content>
                        <v-list-item-title>{{ item.title }}</v-list-item-title>
                    </v-list-item-content>
                </v-list-item>
                </v-list>
        </v-navigation-drawer>
        </div>
    </v-toolbar>
</template>

<script>
export default {
    data () {
        return {
            drawer: null,
            items: [
                { title: 'Home', icon: 'dashboard' },
                { title: 'About', icon: 'question_answer' }
            ]
        }
    }
}
</script>

<style>
#toolbar {
    background-color: darkgreen;
}
.v-btn {
    background-color: darkgreen !important;
}
</style>