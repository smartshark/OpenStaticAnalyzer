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

namespace Columbus.Csharp.Asg.Nodes.Structure {

    /// <summary>
    /// OperatorDeclarationSyntax class, which represents the structure::OperatorDeclarationSyntax node.
    /// </summary>
    [DebuggerDisplay("{DemangledName}")]
#if (CSHARP_INTERNAL)
    internal
#else
    public
#endif
    class OperatorDeclarationSyntax : BaseMethodDeclarationSyntax {


        // ---------- Edges ----------

        /// <summary>The id of the node the ExpressionBody edge points to.</summary>
        protected uint m_ExpressionBody;

        /// <summary>The id of the node the ReturnType edge points to.</summary>
        protected uint m_ReturnType;

        /// <summary>
        /// Constructor, only factory can instantiates nodes.
        /// </summary>
        /// <param name="nodeId">[in] The id of the node.</param>
        /// <param name="factory">[in] Poiter to the Factory the node belongs to.</param>
        public OperatorDeclarationSyntax(uint nodeId, Factory factory) : base(nodeId, factory) {
            m_ExpressionBody = 0;
            m_ReturnType = 0;
        }

        /// <summary>
        /// Gives back the NodeKind of the node.
        /// </summary>
        /// <returns>Returns with the NodeKind.</returns>
        public override Types.NodeKind NodeKind {
            get { return Types.NodeKind.ndkOperatorDeclarationSyntax; }
        }


        // ---------- Reflection getter function ----------

        /// <summary>
        /// Gives back the begin iterator for the edge specified
        /// </summary>
        /// <param name="edge">[in] The multiple edge for which the iterator is requested</param>
        public override ListIterator<Columbus.Csharp.Asg.Nodes.Base.Base> GetListIteratorBegin(string edge) {
            switch(edge) {
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
                default:
                    base.add(edge, nodeId);
                    return;
            }
        }


        // ---------- Edge getter function(s) ----------

        /// <summary>
        /// Gives back the id of the node the ExpressionBody edge points to.
        /// </summary>
        /// <returns>Returns the end point of the m_ExpressionBody edge.</returns>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the edge id is invalid.</exception>
        public uint getExpressionBody() {
            if (fact.getIsFiltered(m_ExpressionBody))
                return 1;
            else
                return m_ExpressionBody;
        }

        /// <summary>
        /// Gives back the id of the node the ReturnType edge points to.
        /// </summary>
        /// <returns>Returns the end point of the m_ReturnType edge.</returns>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the edge id is invalid.</exception>
        public uint getReturnType() {
            if (fact.getIsFiltered(m_ReturnType))
                return 1;
            else
                return m_ReturnType;
        }


        // ---------- Edge setter function(s) ----------

        /// <summary>
        /// Sets the ExpressionBody edge.
        /// </summary>
        /// <param name="nodeId">[in] The new end point of the ExpressionBody edge or 0. With 0 the edge can be deleted.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the nodeId is invalid.</exception>
        public void setExpressionBody(uint nodeId) {
            if (nodeId != 0) {
                if (!fact.getExist(nodeId))
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.OperatorDeclarationSyntax.setExpressionBody(NodeId)", "The end point of the edge does not exist.");

                Columbus.Csharp.Asg.Nodes.Base.Base node = fact.getRef(nodeId);
                if (Common.getIsBaseClassKind(node.NodeKind, Types.NodeKind.ndkArrowExpressionClauseSyntax)) {
                    if (m_ExpressionBody != 0) {
                        removeParentEdge(m_ExpressionBody);
                    }
                    m_ExpressionBody = nodeId;
                    setParentEdge(m_ExpressionBody, (uint)Types.EdgeKind.edkOperatorDeclarationSyntax_ExpressionBody);
                } else {
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.OperatorDeclarationSyntax.setExpressionBody(NodeId)", "Invalid NodeKind (" + node.NodeKind.ToString() + ").");
                }
            } else {
                if (m_ExpressionBody != 0) {
                    removeParentEdge(m_ExpressionBody);
                }
                m_ExpressionBody = 0;
            }
        }

        /// <summary>
        /// Sets the ExpressionBody edge.
        /// </summary>
        /// <param name="node">[in] The new end point of the ExpressionBody edge.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if there's something wrong with the given node.</exception>
        public void setExpressionBody(Columbus.Csharp.Asg.Nodes.Structure.ArrowExpressionClauseSyntax node) {
            if (m_ExpressionBody != 0) {
                removeParentEdge(m_ExpressionBody);
            }
            m_ExpressionBody = node.Id;
            setParentEdge(m_ExpressionBody, (uint)Types.EdgeKind.edkOperatorDeclarationSyntax_ExpressionBody);
        }

        /// <summary>
        /// Sets the ReturnType edge.
        /// </summary>
        /// <param name="nodeId">[in] The new end point of the ReturnType edge or 0. With 0 the edge can be deleted.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the nodeId is invalid.</exception>
        public void setReturnType(uint nodeId) {
            if (nodeId != 0) {
                if (!fact.getExist(nodeId))
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.OperatorDeclarationSyntax.setReturnType(NodeId)", "The end point of the edge does not exist.");

                Columbus.Csharp.Asg.Nodes.Base.Base node = fact.getRef(nodeId);
                if (Common.getIsBaseClassKind(node.NodeKind, Types.NodeKind.ndkTypeSyntax)) {
                    if (m_ReturnType != 0) {
                        removeParentEdge(m_ReturnType);
                    }
                    m_ReturnType = nodeId;
                    setParentEdge(m_ReturnType, (uint)Types.EdgeKind.edkOperatorDeclarationSyntax_ReturnType);
                } else {
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.OperatorDeclarationSyntax.setReturnType(NodeId)", "Invalid NodeKind (" + node.NodeKind.ToString() + ").");
                }
            } else {
                if (m_ReturnType != 0) {
                    removeParentEdge(m_ReturnType);
                }
                m_ReturnType = 0;
            }
        }

        /// <summary>
        /// Sets the ReturnType edge.
        /// </summary>
        /// <param name="node">[in] The new end point of the ReturnType edge.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if there's something wrong with the given node.</exception>
        public void setReturnType(Columbus.Csharp.Asg.Nodes.Expression.TypeSyntax node) {
            if (m_ReturnType != 0) {
                removeParentEdge(m_ReturnType);
            }
            m_ReturnType = node.Id;
            setParentEdge(m_ReturnType, (uint)Types.EdgeKind.edkOperatorDeclarationSyntax_ReturnType);
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

            io.writeUInt4(m_ExpressionBody);
            io.writeUInt4(m_ReturnType);

        }

        /// <summary>
        /// Loads the node.
        /// </summary>
        /// <param name="io">[in] The node is read from io.</param>
        /// <exception cref="Columbus.ColumbusIOException">Throws ColumbusIOException if there is something wrong with the file.</exception>
        public override void load(IO binIo) {
            base.load(binIo);

            m_ExpressionBody =  binIo.readUInt4();
            if (m_ExpressionBody != 0)
              setParentEdge(m_ExpressionBody,(uint)Types.EdgeKind.edkOperatorDeclarationSyntax_ExpressionBody);

            m_ReturnType =  binIo.readUInt4();
            if (m_ReturnType != 0)
              setParentEdge(m_ReturnType,(uint)Types.EdgeKind.edkOperatorDeclarationSyntax_ReturnType);

        }

    }

}
