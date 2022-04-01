﻿using System;

namespace Terminal.Gui.Graphs {
	/// <summary>
	/// Describes how to render a single row/column of a <see cref="GraphView"/> based
	/// on the value(s) in <see cref="ISeries"/> at that location
	/// </summary>
	public class GraphCellToRender {

		/// <summary>
		/// The character to render in the console
		/// </summary>
		public Rune Rune { get; set; }

		/// <summary>
		/// Optional color to render the <see cref="Rune"/> with
		/// </summary>
		public IAttribute Color { get; set; } = new Attribute (-1);

		/// <summary>
		/// Creates instance and sets <see cref="Rune"/> with default graph coloring
		/// </summary>
		/// <param name="rune"></param>
		public GraphCellToRender (Rune rune)
		{
			Rune = rune;
		}
		/// <summary>
		/// Creates instance and sets <see cref="Rune"/> with custom graph coloring
		/// </summary>
		/// <param name="rune"></param>
		/// <param name="color"></param>
		public GraphCellToRender (Rune rune, IAttribute color) : this (rune)
		{
			Color = color;
		}
	}
}