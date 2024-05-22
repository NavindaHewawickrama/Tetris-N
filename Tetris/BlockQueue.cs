﻿using System;
namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new ZBlock(),
            new TBlock()
        };

        private readonly Random random = new Random();

        public Block NextBlock { get; private set; }

        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }

        public void BlockQueu()
        {
            NextBlock = RandomBlock();
        }

        public Block GetAndUpdate()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = RandomBlock();
            } while (block.id == NextBlock.id);

            return block;
        }
    }
}
