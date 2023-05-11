export class User{
    constructor(
        public id:number,
        public firstName:string,
        public lastName:string,
        public identity:string,
        public city:string,
        public street:string,
        public numHome:number,
        public birthDate:Date,
        public cellPhone:string,
        public phone:string
    ){}
}