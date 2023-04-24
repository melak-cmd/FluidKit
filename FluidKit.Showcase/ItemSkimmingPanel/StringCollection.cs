// -------------------------------------------------------------------------------
// 
// This file is part of the FluidKit project: http://www.codeplex.com/fluidkit
// 
// Copyright (c) 2008, The FluidKit community 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met:
// 
// * Redistributions of source code must retain the above copyright notice, this 
// list of conditions and the following disclaimer.
// 
// * Redistributions in binary form must reproduce the above copyright notice, this 
// list of conditions and the following disclaimer in the documentation and/or 
// other materials provided with the distribution.
// 
// * Neither the name of FluidKit nor the names of its contributors may be used to 
// endorse or promote products derived from this software without specific prior 
// written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR 
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES 
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON 
// ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT 
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS 
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 
// -------------------------------------------------------------------------------

using System.Collections.ObjectModel;

namespace FluidKit.Showcase.ItemSkimmingPanel
{
    public class StringCollection : ObservableCollection<string>
    {
        public StringCollection()
        {
            string rootFolder = "/ItemSkimmingPanel/Resources/Images/";
            Add(rootFolder + "01.jpg");
            Add(rootFolder + "02.jpg");
            Add(rootFolder + "03.jpg");
            Add(rootFolder + "04.jpg");
            Add(rootFolder + "05.jpg");
            Add(rootFolder + "06.jpg");
            Add(rootFolder + "07.jpg");
            Add(rootFolder + "08.jpg");
            Add(rootFolder + "09.jpg");
            Add(rootFolder + "10.jpg");
            Add(rootFolder + "11.jpg");
            Add(rootFolder + "12.jpg");
            Add(rootFolder + "13.jpg");
            Add(rootFolder + "14.jpg");
            Add(rootFolder + "15.jpg");
            Add(rootFolder + "16.jpg");
            Add(rootFolder + "17.jpg");
            Add(rootFolder + "18.jpg");
            Add(rootFolder + "19.jpg");
            Add(rootFolder + "20.jpg");
            Add(rootFolder + "21.jpg");
        }
    }
}