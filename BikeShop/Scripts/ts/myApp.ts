let a: boolean = true;

class WebApp {
    name: string;
    constructor() {
        this.name = "Moeen";

        $(() => {
            this.Initialize();
        });
    }
    Start(user: IUser) {
        user.name = "Moeen";
    }

    Initialize() {
        console.log("Application initialized");
    }

    
}

var app = new WebApp();
app.Start({ name: "", age: 20 });