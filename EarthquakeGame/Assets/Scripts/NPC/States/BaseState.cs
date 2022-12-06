public abstract class BaseState
{
    //instance of npc class
    public NPC npc;

    //instance of statemachine class
    public StateMachine stateMachine;

    public abstract void Enter();

    public abstract void Perform();

    public abstract void Exit();
}