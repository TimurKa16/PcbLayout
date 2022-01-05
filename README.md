# PcbLayout

It was 3rd course. We were studying CAD/CAM systems algorithms: pcb layout, arrangement and tracing.
My task for the course work was using iterational algorithm of pcb layout.
It means that I have some elements, number of parts and number of connections between elements.
I have to group elements into parts in order to get minimum external connections between modules.
In other words, it is a graph problem (vertexes as elements and edges as connections).

Here I used a bitmap to draw graphics.

About main mistakes.

1) First of all - naming: classes (Form1,... Form4), methods, textboxes.

2) A code repetition in graphics.
Legacy.

3) Graphics should be in the other static class.