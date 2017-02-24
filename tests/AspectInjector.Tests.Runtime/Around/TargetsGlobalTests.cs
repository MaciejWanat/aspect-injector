﻿using AspectInjector.Tests.Assets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AspectInjector.Tests.Runtime.Around
{
    [TestClass]
    public class TargetsGlobalTests : TestRunner
    {
        [TestMethod]
        public void AdviceAround_Global_Consrtuctor()
        {
            ExecConstructor();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,
                Events.TestConstructorExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Static_Consrtuctor()
        {
            ExecStaticConstructor();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,

                Events.TestStaticConstructorExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Setter()
        {
            ExecSetter();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,

                Events.TestPropertySetterExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Static_Setter()
        {
            ExecStaticSetter();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,

                Events.TestStaticPropertySetterExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Getter()
        {
            ExecGetter();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,

                Events.TestPropertyGetterExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Static_Getter()
        {
            ExecStaticGetter();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,

                Events.TestStaticPropertyGetterExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Add()
        {
            ExecAdd();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,

                Events.TestEventAddExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Static_Add()
        {
            ExecStaticAdd();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,

                Events.TestStaticEventAddExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Remove()
        {
            ExecRemove();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,

                Events.TestEventRemoveExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Static_Remove()
        {
            ExecStaticRemove();
            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,

                Events.TestStaticEventRemoveExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Methods()
        {
            ExecMethod();
            ExecIteratorMethod();
            ExecAsyncVoidMethod();
            ExecAsyncTaskMethod();
            ExecAsyncTypedTaskMethod();

            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,
                Events.TestMethodExit,
                GlobalAspect.AroundExit,

                GlobalAspect.AroundEnter,
                Events.TestIteratorMethodExit,
                GlobalAspect.AroundExit,

                GlobalAspect.AroundEnter,
                Events.TestAsyncMethodExit,
                GlobalAspect.AroundExit,

                GlobalAspect.AroundEnter,
                Events.TestAsyncMethodExit,
                GlobalAspect.AroundExit,

                GlobalAspect.AroundEnter,
                Events.TestAsyncMethodExit,
                GlobalAspect.AroundExit
            });
        }

        [TestMethod]
        public void AdviceAround_Global_Static_Methods()
        {
            ExecStaticMethod();
            ExecStaticIteratorMethod();
            ExecStaticAsyncVoidMethod();
            ExecStaticAsyncTaskMethod();
            ExecStaticAsyncTypedTaskMethod();

            CheckSequence(new List<string> {
                GlobalAspect.AroundEnter,
                Events.TestStaticMethodExit,
                GlobalAspect.AroundExit,

                GlobalAspect.AroundEnter,
                Events.TestStaticIteratorMethodExit,
                GlobalAspect.AroundExit,

                GlobalAspect.AroundEnter,
                Events.TestStaticAsyncMethodExit,
                GlobalAspect.AroundExit,

                GlobalAspect.AroundEnter,
                Events.TestStaticAsyncMethodExit,
                GlobalAspect.AroundExit,

                GlobalAspect.AroundEnter,
                Events.TestStaticAsyncMethodExit,
                GlobalAspect.AroundExit
            });
        }
    }
}