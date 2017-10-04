﻿namespace UnityEngine.Experimental.Rendering.HDPipeline
{
    public class RenderPipelineResources : ScriptableObject
    {
        // Debug
        public Shader debugDisplayLatlongShader;
        public Shader debugViewMaterialGBufferShader;
        public Shader debugViewTilesShader;
        public Shader debugFullScreenShader;

        // Lighting resources
        public Shader deferredShader;
        public Shader screenSpaceAmbientOcclusionShader;
        public ComputeShader subsurfaceScatteringCS;
        public ComputeShader volumetricLightingCS;

        // Lighting tile pass resources
        public ComputeShader clearDispatchIndirectShader;
        public ComputeShader buildDispatchIndirectShader;
        public ComputeShader buildScreenAABBShader;
        public ComputeShader buildPerTileLightListShader;     // FPTL
        public ComputeShader buildPerBigTileLightListShader;
        public ComputeShader buildPerVoxelLightListShader;    // clustered
        public ComputeShader buildMaterialFlagsShader;
        public ComputeShader deferredComputeShader;
        public ComputeShader deferredDirectionalShadowComputeShader;

        // SceneSettings
        // These shaders don't need to be reference by RenderPipelineResource as they are not use at runtime (only to draw in editor)
        // public Shader drawSssProfile;
        // public Shader drawTransmittanceGraphShader;

        public Shader cameraMotionVectors;

        // Sky
        public Shader blitCubemap;
        public ComputeShader buildProbabilityTables;
        public ComputeShader computeGgxIblSampleData;
        public Shader GGXConvolve;

        public Shader skyboxCubemap;
    }
}
