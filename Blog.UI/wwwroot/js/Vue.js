
    var app = new Vue({

        el: '#app',
        data: {
            message: "hhhh",
            kategoriler: []

        },
        methods: {
            listele: function () {
                fetch('https://localhost:44362/api/Category')
                    .then(response => response.json())
                    .then(data => { console.log(data); this.kategoriler = data; });
            }
        },
        created: function () {
            this.listele();
        },
        headers: {
            Authorization: 'Bearer ' + ' ${@Context.Session.GetString("token")}'
        }

    });



