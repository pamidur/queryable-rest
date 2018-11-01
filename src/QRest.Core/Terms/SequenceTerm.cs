﻿using QRest.Core.Contracts;
using QRest.Core.Operations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QRest.Core.Terms
{
    public class SequenceTerm : IEnumerable<ITerm>, ITerm
    {
        private readonly LinkedList<ITerm> _sequence = new LinkedList<ITerm>();

        public ITerm Root => _sequence.First.Value;
        public ITerm Last => _sequence.Last.Value;
        public bool IsEmpty => !_sequence.Any();

        public virtual string SharedView => $"{string.Join("", _sequence.Select(t => t.SharedView))}";
        public virtual string KeyView => string.Join("", _sequence.Select(t => t.KeyView));
        public virtual string DebugView => $"#{string.Join("", _sequence.Select(t => t.DebugView))}";

        public void Add(ITerm term)
        {
            if (term is SequenceTerm s)
                Add(s);
            else if (term != null)
                _sequence.AddLast(term);
        }

        public void Add(SequenceTerm terms)
        {
            foreach (var term in terms)
                Add(term);
        }

        public IEnumerator<ITerm> GetEnumerator()
        {
            return _sequence.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _sequence.GetEnumerator();
        }

        public virtual ITerm Clone() => new SequenceTerm { Root.Clone() };

        public override string ToString() => SharedView;
    }
}