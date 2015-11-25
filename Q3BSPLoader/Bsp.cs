using System;
using System.IO;
using System.Diagnostics;

namespace Bsp
{
    public class Bsp
    {
		Header header;
		string entities;
		Texture[] textures;
		Plane[] planes;
		Node[] nodes;
        Leaf[] leaves;
        LeafFace[] leafFaces;
        LeafBrush[] leafBrushes;
		Model[] models;
		Brush[] brushes;
		BrushSide[] brushSides;
		Vertex[] vertices;
		MeshVertex[] meshVertices;
		Effect[] effects;
		Face[] faces;

        public Bsp(string filename)
        {
            #region Start Profiling
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            #endregion

            using (BinaryReader reader = new BinaryReader(new FileStream(filename, FileMode.Open)))
            {
                #region Header
                header = new Header(reader);
                #endregion
                
                #region Textures
                textures = new Texture[header.DirectoryEntries[(int)Lump.Textures].Length / Texture.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.Textures), SeekOrigin.Begin);
                for (int i = 0; i < textures.Length; i++)
                    textures[i] = new Texture(reader);
                #endregion
                
                #region Planes
                planes = new Plane[header.DirectoryEntries[(int)Lump.Planes].Length / Plane.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.Planes), SeekOrigin.Begin);
                for (int i = 0; i < planes.Length; i++)
                    planes[i] = new Plane(reader);
                #endregion

                #region Nodes
                nodes = new Node[header.DirectoryEntries[(int)Lump.Nodes].Length / Node.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.Nodes), SeekOrigin.Begin);
                for (int i = 0; i < nodes.Length; i++)
                {
                    nodes[i] = new Node();
                    nodes[i].Load(reader);
                }
                #endregion

                #region Leaves
                leaves = new Leaf[header.DirectoryEntries[(int)Lump.Leaves].Length / Leaf.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.Leaves), SeekOrigin.Begin);
                for (int i = 0; i < leaves.Length; i++)
                {
                    leaves[i] = new Leaf();
                    leaves[i].Load(reader);
                }
                #endregion

                #region Leaf Faces
                leafFaces = new LeafFace[header.DirectoryEntries[(int)Lump.LeafFaces].Length / LeafFace.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.LeafFaces), SeekOrigin.Begin);
                for (int i = 0; i < leafFaces.Length; i++)
                {
                    leafFaces[i] = new LeafFace();
                    leafFaces[i].Load(reader);
                }
                #endregion

                #region LeafBrushes
                leafBrushes = new LeafBrush[header.DirectoryEntries[(int)Lump.LeafBrushes].Length / LeafBrush.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.LeafBrushes), SeekOrigin.Begin);
                for (int i = 0; i < leafBrushes.Length; i++)
                    leafBrushes[i] = new LeafBrush(reader);
                #endregion

                #region Models
                models = new Model[header.DirectoryEntries[(int)Lump.Models].Length / Model.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.Models), SeekOrigin.Begin);
                for (int i = 0; i < models.Length; i++)
                    models[i] = new Model(reader);
                #endregion

                #region Brushes
                brushes = new Brush[header.DirectoryEntries[(int)Lump.Brushes].Length / Brush.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.Brushes), SeekOrigin.Begin);
                for (int i = 0; i < brushes.Length; i++)
                    brushes[i] = new Brush(reader);
                #endregion

                #region BrushSides
                brushSides = new BrushSide[header.DirectoryEntries[(int)Lump.BrushSides].Length / BrushSide.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.BrushSides), SeekOrigin.Begin);
                for (int i = 0; i < brushSides.Length; i++)
                    brushSides[i] = new BrushSide(reader);
                #endregion

                #region Vertices
                vertices = new Vertex[header.DirectoryEntries[(int)Lump.Vertices].Length / Vertex.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.Vertices), SeekOrigin.Begin);
                for (int i = 0; i < vertices.Length; i++)
                    vertices[i] = new Vertex(reader);
                #endregion

                #region Mesh Vertices
                meshVertices = new MeshVertex[header.DirectoryEntries[(int)Lump.MeshVertices].Length / MeshVertex.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.MeshVertices), SeekOrigin.Begin);
                for (int i = 0; i < meshVertices.Length; i++)
                    meshVertices[i] = new MeshVertex(reader);
                #endregion

                #region Effects
                effects = new Effect[header.DirectoryEntries[(int)Lump.Effects].Length / Effect.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.Effects), SeekOrigin.Begin);
                for (int i = 0; i < effects.Length; i++)
                    effects[i] = new Effect(reader);
                #endregion

                #region Faces
                faces = new Face[header.DirectoryEntries[(int)Lump.Faces].Length / Face.Size];
                reader.BaseStream.Seek(LumpOffset(Lump.Faces), SeekOrigin.Begin);
                for (int i = 0; i < faces.Length; i++)
                    faces[i] = new Face(reader);
                #endregion
            }

            #region Stop Profiling
            stopwatch.Stop();
            #endregion

            #region Log
			Console.WriteLine("Loaded {0:d} textures, {1:d} planes, {2:d} nodes, {3:d} leaves, {4:d} leaf faces, {5:d} leaf brushes, {6:d} models, {7:d} brushes, {8:d} brush sides, {9:d} vertices, {10:d} mesh vertices, {11:d} effects, and {12:d} faces from {13:s} in {14:s}ms.",
                textures.Length,
                planes.Length,
                nodes.Length,
                leaves.Length,
                leafFaces.Length,
                leafBrushes.Length,
                models.Length,
                brushes.Length,
                brushSides.Length,
                vertices.Length,
                meshVertices.Length,
                effects.Length,
                faces.Length,
				filename,
                stopwatch.Elapsed.TotalMilliseconds.ToString()
            );
            #endregion
        }

        private int LumpOffset(Lump lump)
        {
            return header.DirectoryEntries[(int)lump].Offset;
        }
    }
}