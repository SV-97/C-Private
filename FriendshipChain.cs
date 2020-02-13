using System;
using System.Collections.Generic;
using System.Linq;

#nullable enable // enable non nullables ... aaaaaaaaand there's a NullReferenceException - wtf?
class Program {

    class UCLinkedList<T> : LinkedList<T> where T: IEquatable<T> {

        public UCLinkedList<T> PushFront(T value) {
            if (!value.Equals(First.Value)) {
                this.AddFirst(value);
            }
            return this;
        }

        public UCLinkedList<T> PushBack(T value) {
            if (!value.Equals(Last.Value)) {
                this.AddLast(value);
            }
            return this;
        }

        public T PopFront() {
            return this.First.Value;
        }

        public UCLinkedList<T> Concat(UCLinkedList<T> other) {
            foreach (var node in other) {
                this.AddLast(node);
            }
            return this;
        }

        public UCLinkedList<T> Reverse() {
            var chain = new UCLinkedList<T>();
            foreach (var node in this) {
                chain.PushFront(node);
            }
            return chain;
            /* TODO: do this properly
            ref var left = this.First;
            ref var right = this.Last;
            for (var i = 0; i <= this.Count / 2; i++) {
                (left, right) = (right, left);
                
            }
            */
        }
    }

    class Kid : IEquatable<Kid> {
        public Kid(string name, List<Kid> friends) {
            this.Name = name;
            this.Friends = friends;
        }
        public string Name { get; }
        
        public List<Kid> Friends { get; } // yes this could be made generic over the type of collection but no
        
        public bool Equals(Kid other) {
            return this.Name == other.Name && this.Friends == other.Friends;
        }

        public bool Knows(Kid other) {
            return this.Friends.Contains(other) || other.Friends.Contains(this);
        }

        public FriendShipAbility CanBeFriendsWith(Kid other) {
            switch (this) {
                case var x when this.Equals(other):
                    return new SameKid(this);
                case var x when this.Friends.Count == 0 && other.Friends.Count == 0:
                    return new CantBeFriends();
                case var x when this.Friends.Count > 0 && this.Knows(other):
                    return new Via(this, other);
                case var x when this.Friends.Count > 0:
                    var connection = this.Friends
                        .Select(x => x.CanBeFriendsWith(other))
                        .Where(x => {
                            switch(x) {
                                case CantBeFriends o: return false;
                                default: return true;
                            }
                        }).First();
                    return (new SameKid(this)).Combine(connection).Combine(new SameKid(other));
                case var x when this.Friends.Count == 0 && this.Knows(other):
                    return new Via(this, other);
                default:
                    return other.CanBeFriendsWith(this).Reverse();
            }
        }
    }

    abstract class FriendShipAbility {
        public abstract FriendShipAbility Combine(FriendShipAbility other);
        public abstract FriendShipAbility Reverse();
    }

    class CantBeFriends : FriendShipAbility {
        public CantBeFriends() {}
        public override FriendShipAbility Combine(FriendShipAbility other) {
            return this;
        }
        
        override public FriendShipAbility Reverse() {
            return this;            
        }
    }

    class SameKid : FriendShipAbility {
        public SameKid(Kid kid) {
            this.Kid = kid;
        }

        public Kid Kid { get; }

        public override FriendShipAbility Combine(FriendShipAbility other) {
            switch (other)
            {
                case CantBeFriends o:
                    return o;
                case Via o:
                    return new Via(o.Chain.PushFront(Kid));
                case SameKid o:
                    return new Via(Kid, o.Kid);
                default: throw new NotImplementedException();
            }
        }
        
        override public FriendShipAbility Reverse() {
            return this;            
        }
    }

    class Via : FriendShipAbility {
        public Via(UCLinkedList<Kid> chain) {
            if (chain.Count < 2) {
                throw new ArgumentException("A Chain has to be at least two elements long.");
            }
            this.Chain = chain;
        }

        public Via(Kid k1, Kid k2) {
            var chain = new UCLinkedList<Kid>();
            chain.PushFront(k2);
            chain.PushFront(k1);
            Chain = chain;
        }

        public UCLinkedList<Kid> Chain { get; }

        public override FriendShipAbility Combine(FriendShipAbility other) {
            switch (other)
            {
                case CantBeFriends o:
                    return o;
                case Via o:
                    return new Via(Chain.Concat(o.Chain));
                case SameKid o:
                    return new Via(Chain.PushBack(o.Kid));
                default: throw new NotImplementedException();
            }
        }

        override public FriendShipAbility Reverse() {
            this.Chain.Reverse();
            return this;            
        }
    }

    static void Main(string[] args) {
        var bob = new Kid("Bob", new List<Kid>());
        var alice = new Kid("Alice", new List<Kid>());
        var jimList = new List<Kid>();
        jimList.Add(bob);
        jimList.Add(alice);
        var jim = new Kid("Jim", jimList);
        var joeList = new List<Kid>();
        joeList.Add(bob);
        var joe = new Kid("Joe", joeList);
        var dudeList = new List<Kid>();
        dudeList.Add(jim);
        dudeList.Add(alice);
        var dude = new Kid("Dude", dudeList);
        var sophieList = new List<Kid>();
        sophieList.Add(dude);
        var sophie = new Kid("Sophie", sophieList);
        var margretList = new List<Kid>();
        margretList.Add(sophie);
        var margret = new Kid("Margret", margretList);

        try {
            Console.WriteLine($"{bob.CanBeFriendsWith(bob)}");
            var v2 = bob.CanBeFriendsWith(alice);
            Console.WriteLine($"{v2}");
            var v3 = bob.CanBeFriendsWith(jim);
            Console.WriteLine($"{v3}");
        } catch( NullReferenceException e ) {
            Console.WriteLine($"{e.Source}")
        }
        return;
    }
}