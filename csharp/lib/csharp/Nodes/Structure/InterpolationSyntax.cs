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
    /// InterpolationSyntax class, which represents the structure::InterpolationSyntax node.
    /// </summary>
    [DebuggerDisplay("{DemangledName}")]
#if (CSHARP_INTERNAL)
    internal
#else
    public
#endif
    class InterpolationSyntax : InterpolatedStringContentSyntax {


        // ---------- Edges ----------

        /// <summary>The id of the node the AlignmentClause edge points to.</summary>
        protected uint m_AlignmentClause;

        /// <summary>The id of the node the Expression edge points to.</summary>
        protected uint m_Expression;

        /// <summary>The id of the node the FormatClause edge points to.</summary>
        protected uint m_FormatClause;

        /// <summary>
        /// Constructor, only factory can instantiates nodes.
        /// </summary>
        /// <param name="nodeId">[in] The id of the node.</param>
        /// <param name="factory">[in] Poiter to the Factory the node belongs to.</param>
        public InterpolationSyntax(uint nodeId, Factory factory) : base(nodeId, factory) {
            m_AlignmentClause = 0;
            m_Expression = 0;
            m_FormatClause = 0;
        }

        /// <summary>
        /// Gives back the NodeKind of the node.
        /// </summary>
        /// <returns>Returns with the NodeKind.</returns>
        public override Types.NodeKind NodeKind {
            get { return Types.NodeKind.ndkInterpolationSyntax; }
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
        /// Gives back the id of the node the AlignmentClause edge points to.
        /// </summary>
        /// <returns>Returns the end point of the m_AlignmentClause edge.</returns>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the edge id is invalid.</exception>
        public uint getAlignmentClause() {
            if (fact.getIsFiltered(m_AlignmentClause))
                return 1;
            else
                return m_AlignmentClause;
        }

        /// <summary>
        /// Gives back the id of the node the Expression edge points to.
        /// </summary>
        /// <returns>Returns the end point of the m_Expression edge.</returns>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the edge id is invalid.</exception>
        public uint getExpression() {
            if (fact.getIsFiltered(m_Expression))
                return 1;
            else
                return m_Expression;
        }

        /// <summary>
        /// Gives back the id of the node the FormatClause edge points to.
        /// </summary>
        /// <returns>Returns the end point of the m_FormatClause edge.</returns>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the edge id is invalid.</exception>
        public uint getFormatClause() {
            if (fact.getIsFiltered(m_FormatClause))
                return 1;
            else
                return m_FormatClause;
        }


        // ---------- Edge setter function(s) ----------

        /// <summary>
        /// Sets the AlignmentClause edge.
        /// </summary>
        /// <param name="nodeId">[in] The new end point of the AlignmentClause edge or 0. With 0 the edge can be deleted.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the nodeId is invalid.</exception>
        public void setAlignmentClause(uint nodeId) {
            if (nodeId != 0) {
                if (!fact.getExist(nodeId))
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.InterpolationSyntax.setAlignmentClause(NodeId)", "The end point of the edge does not exist.");

                Columbus.Csharp.Asg.Nodes.Base.Base node = fact.getRef(nodeId);
                if (Common.getIsBaseClassKind(node.NodeKind, Types.NodeKind.ndkInterpolationAlignmentClauseSyntax)) {
                    if (m_AlignmentClause != 0) {
                        removeParentEdge(m_AlignmentClause);
                    }
                    m_AlignmentClause = nodeId;
                    setParentEdge(m_AlignmentClause, (uint)Types.EdgeKind.edkInterpolationSyntax_AlignmentClause);
                } else {
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.InterpolationSyntax.setAlignmentClause(NodeId)", "Invalid NodeKind (" + node.NodeKind.ToString() + ").");
                }
            } else {
                if (m_AlignmentClause != 0) {
                    removeParentEdge(m_AlignmentClause);
                }
                m_AlignmentClause = 0;
            }
        }

        /// <summary>
        /// Sets the AlignmentClause edge.
        /// </summary>
        /// <param name="node">[in] The new end point of the AlignmentClause edge.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if there's something wrong with the given node.</exception>
        public void setAlignmentClause(Columbus.Csharp.Asg.Nodes.Structure.InterpolationAlignmentClauseSyntax node) {
            if (m_AlignmentClause != 0) {
                removeParentEdge(m_AlignmentClause);
            }
            m_AlignmentClause = node.Id;
            setParentEdge(m_AlignmentClause, (uint)Types.EdgeKind.edkInterpolationSyntax_AlignmentClause);
        }

        /// <summary>
        /// Sets the Expression edge.
        /// </summary>
        /// <param name="nodeId">[in] The new end point of the Expression edge or 0. With 0 the edge can be deleted.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the nodeId is invalid.</exception>
        public void setExpression(uint nodeId) {
            if (nodeId != 0) {
                if (!fact.getExist(nodeId))
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.InterpolationSyntax.setExpression(NodeId)", "The end point of the edge does not exist.");

                Columbus.Csharp.Asg.Nodes.Base.Base node = fact.getRef(nodeId);
                if (Common.getIsBaseClassKind(node.NodeKind, Types.NodeKind.ndkExpressionSyntax)) {
                    if (m_Expression != 0) {
                        removeParentEdge(m_Expression);
                    }
                    m_Expression = nodeId;
                    setParentEdge(m_Expression, (uint)Types.EdgeKind.edkInterpolationSyntax_Expression);
                } else {
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.InterpolationSyntax.setExpression(NodeId)", "Invalid NodeKind (" + node.NodeKind.ToString() + ").");
                }
            } else {
                if (m_Expression != 0) {
                    removeParentEdge(m_Expression);
                }
                m_Expression = 0;
            }
        }

        /// <summary>
        /// Sets the Expression edge.
        /// </summary>
        /// <param name="node">[in] The new end point of the Expression edge.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if there's something wrong with the given node.</exception>
        public void setExpression(Columbus.Csharp.Asg.Nodes.Expression.ExpressionSyntax node) {
            if (m_Expression != 0) {
                removeParentEdge(m_Expression);
            }
            m_Expression = node.Id;
            setParentEdge(m_Expression, (uint)Types.EdgeKind.edkInterpolationSyntax_Expression);
        }

        /// <summary>
        /// Sets the FormatClause edge.
        /// </summary>
        /// <param name="nodeId">[in] The new end point of the FormatClause edge or 0. With 0 the edge can be deleted.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if the nodeId is invalid.</exception>
        public void setFormatClause(uint nodeId) {
            if (nodeId != 0) {
                if (!fact.getExist(nodeId))
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.InterpolationSyntax.setFormatClause(NodeId)", "The end point of the edge does not exist.");

                Columbus.Csharp.Asg.Nodes.Base.Base node = fact.getRef(nodeId);
                if (Common.getIsBaseClassKind(node.NodeKind, Types.NodeKind.ndkInterpolationFormatClauseSyntax)) {
                    if (m_FormatClause != 0) {
                        removeParentEdge(m_FormatClause);
                    }
                    m_FormatClause = nodeId;
                    setParentEdge(m_FormatClause, (uint)Types.EdgeKind.edkInterpolationSyntax_FormatClause);
                } else {
                    throw new CsharpException("Columbus.Csharp.Asg.Nodes.Structure.InterpolationSyntax.setFormatClause(NodeId)", "Invalid NodeKind (" + node.NodeKind.ToString() + ").");
                }
            } else {
                if (m_FormatClause != 0) {
                    removeParentEdge(m_FormatClause);
                }
                m_FormatClause = 0;
            }
        }

        /// <summary>
        /// Sets the FormatClause edge.
        /// </summary>
        /// <param name="node">[in] The new end point of the FormatClause edge.</param>
        /// <exception cref="Columbus.Csharp.Asg.CsharpException">Throws CsharpException if there's something wrong with the given node.</exception>
        public void setFormatClause(Columbus.Csharp.Asg.Nodes.Structure.InterpolationFormatClauseSyntax node) {
            if (m_FormatClause != 0) {
                removeParentEdge(m_FormatClause);
            }
            m_FormatClause = node.Id;
            setParentEdge(m_FormatClause, (uint)Types.EdgeKind.edkInterpolationSyntax_FormatClause);
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

            io.writeUInt4(m_AlignmentClause);
            io.writeUInt4(m_Expression);
            io.writeUInt4(m_FormatClause);

        }

        /// <summary>
        /// Loads the node.
        /// </summary>
        /// <param name="io">[in] The node is read from io.</param>
        /// <exception cref="Columbus.ColumbusIOException">Throws ColumbusIOException if there is something wrong with the file.</exception>
        public override void load(IO binIo) {
            base.load(binIo);

            m_AlignmentClause =  binIo.readUInt4();
            if (m_AlignmentClause != 0)
              setParentEdge(m_AlignmentClause,(uint)Types.EdgeKind.edkInterpolationSyntax_AlignmentClause);

            m_Expression =  binIo.readUInt4();
            if (m_Expression != 0)
              setParentEdge(m_Expression,(uint)Types.EdgeKind.edkInterpolationSyntax_Expression);

            m_FormatClause =  binIo.readUInt4();
            if (m_FormatClause != 0)
              setParentEdge(m_FormatClause,(uint)Types.EdgeKind.edkInterpolationSyntax_FormatClause);

        }

    }

}
