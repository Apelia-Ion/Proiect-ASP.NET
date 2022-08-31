export class Register {
   // public username : string | undefined;
    public email :string | undefined;
    public password: string |undefined;
    public roleId: string | undefined;

    public constructor(init? : Partial<Register>) 
    {
        Object.assign(this, init);
        this.roleId = 'Chef';

    }

    // public constructor(un='default',e='default',ri='Chef') 
    // {
    //     this.username=un;
    //     this.email=e;
    //     this.roleId=ri;

    // }
}