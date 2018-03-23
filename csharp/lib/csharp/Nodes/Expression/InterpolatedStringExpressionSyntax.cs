/*
 *  This file is part of OpenStaticAnalyzer.
 *
 *  Copyright (c) 2004-2017 Department of Software Engineering - University of Szeged
 *
 *  Licensed under Version 1.2 of the EUPL (the "Licence");
 *
 *  You may not use this work except in compliance with the Licence.
 *
 *  You may obtain a copy of the Licence in the LICENSE file or at:
 *
 *  https://joinup.ec.europa.eu/software/page/eupl
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the Licence is distributed on an "AS IS" basis,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the Licence for the specific language governing permissions and
 *  limitations under the Licence.
 */

using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;

namespace Columbus.Csharp.Asg.Nodes.Expression {

    /// <summary>
    /// InterpolatedStringExpressionSyntax class, which represents the expression::InterpolatedStringExpressionSyntax node.
    /// </summary>
    [DebuggerDisplay("{DemangledName}")]
#if (CSHARP_INTERNAL)
    internal
#else
    public
#endif
    class InterpolatedStringExpressionSyntax : ExpressionSyntax {


        // ---------- Edges ----------

        /// <summary>Container stores the id of the nodes the Contents edge points to.</summary>
        protected LinkedList<uint> ContentsContainer;

        /// <summary>
        /// Constructor, only factory can instantiates nodes.
        /// </summary>
        /// <param name="nodeId">[in] The id of the node.</param>
        /// <param name="factory">[in] Poiter to the Factory the node belongs to.</param>
        public InterpolatedStringExpressionSyntax(uint nodeId, Factory factory) : base(nodeId, factory) {
            ContentsContainer = new LinkedList<uint>();
        }

        /// <summary>
        /// Gives back the NodeKind of the node.
        /// </summary>
        /// <returns>Returns with the NodeKind.</returns>
        public override Types.NodeKind NodeKind {
            get { return Types.NodeKind.ndkInterpolatedStringExpressionSyntax; }
        }


        // ---------- Reflection getter function ----------

        /// <summary>
        /// Gives back the begin iterator for the edge specified
        /// </summary>
        /// <param name="edge">[in] The multiple edge for which the iterator is requested</param>
        public override ListIterator<Columbus.Csharp.Asg.Nodes.Base.Base> GetListIteratorBegin(string edge) {
            switch(edge) {
                case "Contents":
                    return ContentsListIteratorBegin.Convert<Columbus.Csharp.Asg.Nodes.Base.Base>();
                default:
                    return base.GetListIteratorBegin(edge);
            }
        }


        // ---------- Reflection add function ----------

        /// <summary>
        /// Adds item as a new edge
        /// </summary>
        public override void add(string edge, uint nodeId) {
            switch(edge) {
                case "Contents":
                    addContents(nodeId);
                    return;
                default:
                    base.add(edge, nodeId);
                    return;
            }
        }


        // ---------- Edge getter function(s) ----------

        /// <summary>
        /// Gives back iterator for the Contents edges.
        /// </summary>
        /// <returns>Returns an iterator for the Contents edges.</returns>
        public ListIterator<Columbus.Csharp.Asg.Nodes.Structure.InterpolatedStringContentSyntax> ContentsListIteratorBegin {
            get {
                return new ListIterator<Columbus.Csharp.Asg.Nodes.Structure.InterpolatedStringContentSyntax>(ContentsContainer, fact, true);
            }
        }

        /// <summary>
        /// Gives back iterator for the Contents edges.
        /// </summary>
        /// <returns>Returns an iterator for the Contents edges.</returns>
        public ListIterator<Columbus.Csharp.Asg.Nodes.Structure.InterpolatedStringContentSyntax> ContentsListIteratorEnd {
            get {
                return new ListIterator<Columbus.Csharp.Asg.Nodes.Structure.InterpolatedStringContentSyntax>(ContentsContainer, fact, false);
            }
        }

        /// <summary>
        /// Tells whether the node has Contents edges or not.
        /// </summary>
        /// <returns>Returns true if the node has at least one Contents edge.</returns>
        public bool ContentsIsEmpty {
            get { return ContentsContainer.Count == 0; }
        }

        /// <summary>
        /// Gives back how many Contents edges the node has.
        /// </summary>
        /// <returns>Returns with the number of Contents edges.</returns>
        public uint ContentsSize {
            get { return (uint)(ContentsContainer.Count); }
        }


        // ---------- Edge setter function(s) ----------

        /// <summary>
        /// Adds a new Contents edge to the node and inserts it after the other ones.
        /// </summary>
        /// <param name="node">[in] The end point of the new Contents edge.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if there is something wrong with the given node.</exception>
        public void addContents(Columbus.Csharp.Asg.Nodes.Structure.InterpolatedStringContentSyntax node) {
            addContents(node.Id);
        }

        /// <summary>
        /// Adds a new Contents edge to the node and inserts it after the other ones.
        /// </summary>
        /// <param name="nodeId">[in] The end point of the new Contents edge.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the given nodeId is invalid.</exception>
        public void addContents(uint nodeId) {
            if (!fact.getExist(nodeId))
                throw new CsharpException("Columbus.Csharp.Asg.Nodes.Expression.InterpolatedStringExpressionSyntax.addContents(NodeId)", "The end point of the edge does not exist.");
            Columbus.Csharp.Asg.Nodes.Base.Base node = fact.getRef(nodeId);
            if (Common.getIsBaseClassKind(node.NodeKind, Types.NodeKind.ndkInterpolatedStringContentSyntax)) {
                ContentsContainer.AddLast(nodeId);
            } else {
                throw new CsharpException("Columbus.Csharp.Asg.Nodes.Expression.InterpolatedStringExpressionSyntax.setContents(NodeId)", "Invalid NodeKind (" + node.NodeKind.ToString() + ").");
            }
           setParentEdge(nodeId, (uint)Types.EdgeKind.edkInterpolatedStringExpressionSyntax_Contents);
            if (fact.ReverseEdges != null)
              fact.ReverseEdges.insertEdge(nodeId, this.Id, Types.EdgeKind.edkInterpolatedStringExpressionSyntax_Contents);
        }


        // ---------- Accept functions for Visitor ----------

        /// <summary>
        /// It calls the appropriate visit method of the given visitor.
        /// </summary>
        /// <param name="visitor">[in] The used visitor.</param>
        public override void accept(Visitors.Visitor visitor) {
            visitor.visit(this);
        }

        /// <summary>
        /// It calls the appropriate visitEnd method of the given visitor.
        /// </summary>
        /// <param name="visitor">[in] The used visitor.</param>
        public override void acceptEnd(Visitors.Visitor visitor) {
            visitor.visitEnd(this);
        }

        /// <summary>
        /// Saves the node.
        /// </summary>
        /// <param name="io">[in] The node is written into io.</param>
        /// <exception cref="Columbus.ColumbusIOException">Throws ColumbusIOException if there is something wrong with the file.</exception>
        public override void save(IO io) {
            base.save(io);


            foreach (var Contents in ContentsContainer) {
              io.writeUInt4(Contents);
            }
            io.writeUInt4(0); // This is the end sign
        }

        /// <summary>
        /// Loads the node.
        /// </summary>
        /// <param name="io">[in] The node is read from io.</param>
        /// <exception cref="Columbus.ColumbusIOException">Throws ColumbusIOException if there is something wrong with the file.</exception>
        public override void load(IO binIo) {
            base.load(binIo);

            uint _id;

            _id = binIo.readUInt4();
            while (_id != 0) {
              ContentsContainer.AddLast(_id);
              setParentEdge(_id, (uint)Types.EdgeKind.edkInterpolatedStringExpressionSyntax_Contents);
              _id = binIo.readUInt4();
            }
        }

    }

}
