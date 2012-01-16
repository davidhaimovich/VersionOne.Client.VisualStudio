﻿using Ninject;

namespace VersionOne.VisualStudio.VSPackage.Dependencies {
    public class ComponentResolver<TComponent> {
        private readonly IKernel container;
        private readonly string name;

        public ComponentResolver(IKernel container, string name = null) {
            this.container = container;
            this.name = name;
        }

        public TComponent Resolve() {
            return name == null ? container.TryGet<TComponent>() : container.TryGet<TComponent>(name);
        }
    }
}