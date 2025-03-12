using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace jurnalModul4_103022300018
{
    class FanLaptop
    {

        public enum State {Queit, Balanced, Perfomance, Turbo}
        
        public enum Trigger {mode_down, mode_up, turbo_shortcut}

        struct transition
        {
            public State prevState;
            public State nextState;
            public Trigger trigger;

            public transition(State prevState, State nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        transition[] transitions =
            {
                new transition(State.Queit, State.Balanced, Trigger.mode_up),
                new transition(State.Queit, State.Turbo, Trigger.turbo_shortcut),
                new transition(State.Balanced, State.Perfomance, Trigger.mode_up),
                new transition(State.Balanced, State.Queit, Trigger.mode_down),
                new transition(State.Perfomance, State.Turbo, Trigger.mode_up),
                new transition(State.Perfomance, State.Balanced, Trigger.mode_down),
                new transition(State.Turbo, State.Queit, Trigger.turbo_shortcut),
                new transition(State.Turbo, State.Perfomance, Trigger.mode_down),
            };

        public State currentState = State.Queit;

        public State GetState(State prevState, Trigger trigger)
        {
            State nextState = State.Queit;
            foreach (transition t in transitions)
            {
                if (t.prevState == prevState && t.trigger == trigger)
                {
                    nextState = t.nextState;
                }
            }
        }
        public void changeState(Trigger trigger)
        {
            State nextState = GetState(currentState, trigger);
            currentState = nextState;
        }
    }
}
