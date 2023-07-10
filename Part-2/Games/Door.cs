using App1.Helpers;

class Door
{
    private int _passphrase;
    public ChestState DoorState {get;private set;} 
    
    public Door(int initPasscode)
    {
        _passphrase = initPasscode;
        DoorState = ChestState.Lock;
    }

    public void Close()
    {
        if (DoorState == ChestState.Open) DoorState = ChestState.Close;
    }

    public void Open()
    {
        if (DoorState == ChestState.Close) DoorState = ChestState.Open;
    }

    public void Lock()
    {
        if (DoorState == ChestState.Close) DoorState = ChestState.Lock;
    }

    public void Unlock(int passcode)
    {
        if (DoorState == ChestState.Lock && passcode == _passphrase) DoorState = ChestState.Close;
    }

    public void ChangeCode(int oldPasscode, int newPasscode)
    {
        if (oldPasscode == _passphrase) _passphrase = newPasscode;
    }
}