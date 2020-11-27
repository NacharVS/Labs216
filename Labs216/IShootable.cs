using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216
{
    
    interface IForBluindings
    {
        public void Collab();
    }
    interface IArcher
    {
        public void Move();
        public void Shoot();
        public void Blind();
        public void Fight();

    }
    interface IHeartBreakers
    {
        public void Move();
        public void Shoot();
        public void Blind();
    }
    interface ILaraCroft
    {
        public void Move();
        public void Shoot();
        public void Fight();
    }
    interface ILuckyguy
    {
        public void Move();
        public void Shoot();
        public void Blind();
        public void Jump();
    }
    interface IMario
    {
        public void Move();
        public void Shoot();
        public void Jump();
    }
    
    interface ITraveler
    {
        public void EnjoyLife();
        public void Move();
    }
    interface ITeacher
    {
        public void Move();
        public void Explain();
        public void Check();
        public void Help();
    }
    interface IMedic
    {
        public void Move();
        public void Examine();
        public void Treats();
        public void Help();
    }
    interface ICook
    {
        public void Move();
        public void Cooking();
    }
    interface IAssistant
    {
        public void Move();
        public void Help();
    }
}
