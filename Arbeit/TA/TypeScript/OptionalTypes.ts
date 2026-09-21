
interface User {
    id: number,
    username: string,
    bio?:string,
};

const user1: User={
    id: 1,
    username: "Dev01"
};

const user2: User={
    id:2,
    username: "Dev02",
    bio: "Servas de wadl"
}


function greet(name: string, greet?:string) {
    if(greet)
    {
        return '$(greet) $(name)';
    }
    else
    {
        return 'Hallo $(name)';
    }
}







