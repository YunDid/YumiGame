x87D9
#define GL_NEGATIVE_Y_EXT                 0x87DA
#define GL_NEGATIVE_Z_EXT                 0x87DB
#define GL_NEGATIVE_W_EXT                 0x87DC
#define GL_ZERO_EXT                       0x87DD
#define GL_ONE_EXT                        0x87DE
#define GL_NEGATIVE_ONE_EXT               0x87DF
#define GL_NORMALIZED_RANGE_EXT           0x87E0
#define GL_FULL_RANGE_EXT                 0x87E1
#define GL_CURRENT_VERTEX_EXT             0x87E2
#define GL_MVP_MATRIX_EXT                 0x87E3
#define GL_VARIANT_VALUE_EXT              0x87E4
#define GL_VARIANT_DATATYPE_EXT           0x87E5
#define GL_VARIANT_ARRAY_STRIDE_EXT       0x87E6
#define GL_VARIANT_ARRAY_TYPE_EXT         0x87E7
#define GL_VARIANT_ARRAY_EXT              0x87E8
#define GL_VARIANT_ARRAY_POINTER_EXT      0x87E9
#define GL_INVARIANT_VALUE_EXT            0x87EA
#define GL_INVARIANT_DATATYPE_EXT         0x87EB
#define GL_LOCAL_CONSTANT_VALUE_EXT       0x87EC
#define GL_LOCAL_CONSTANT_DATATYPE_EXT    0x87ED
typedef void (APIENTRYP PFNGLBEGINVERTEXSHADEREXTPROC) (void);
typedef void (APIENTRYP PFNGLENDVERTEXSHADEREXTPROC) (void);
typedef void (APIENTRYP PFNGLBINDVERTEXSHADEREXTPROC) (GLuint id);
typedef GLuint (APIENTRYP PFNGLGENVERTEXSHADERSEXTPROC) (GLuint range);
typedef void (APIENTRYP PFNGLDELETEVERTEXSHADEREXTPROC) (GLuint id);
typedef void (APIENTRYP PFNGLSHADEROP1EXTPROC) (GLenum op, GLuint res, GLuint arg1);
typedef void (APIENTRYP PFNGLSHADEROP2EXTPROC) (GLenum op, GLuint res, GLuint arg1, GLuint arg2);
typedef void (APIENTRYP PFNGLSHADEROP3EXTPROC) (GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);
typedef void (APIENTRYP PFNGLSWIZZLEEXTPROC) (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
typedef void (APIENTRYP PFNGLWRITEMASKEXTPROC) (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
typedef void (APIENTRYP PFNGLINSERTCOMPONENTEXTPROC) (GLuint res, GLuint src, GLuint num);
typedef void (APIENTRYP PFNGLEXTRACTCOMPONENTEXTPROC) (GLuint res, GLuint src, GLuint num);
typedef GLuint (APIENTRYP PFNGLGENSYMBOLSEXTPROC) (GLenum datatype, GLenum storagetype, GLenum range, GLuint components);
typedef void (APIENTRYP PFNGLSETINVARIANTEXTPROC) (GLuint id, GLenum type, const void *addr);
typedef void (APIENTRYP PFNGLSETLOCALCONSTANTEXTPROC) (GLuint id, GLenum type, const void *addr);
typedef void (APIENTRYP PFNGLVARIANTBVEXTPROC) (GLuint id, const GLbyte *addr);
typedef void (APIENTRYP PFNGLVARIANTSVEXTPROC) (GLuint id, const GLshort *addr);
typedef void (APIENTRYP PFNGLVARIANTIVEXTPROC) (GLuint id, const GLint *addr);
typedef void (APIENTRYP PFNGLVARIANTFVEXTPROC) (GLuint id, const GLfloat *addr);
typedef void (APIENTRYP PFNGLVARIANTDVEXTPROC) (GLuint id, const GLdouble *addr);
typedef void (APIENTRYP PFNGLVARIANTUBVEXTPROC) (GLuint id, const GLubyte *addr);
typedef void (APIENTRYP PFNGLVARIANTUSVEXTPROC) (GLuint id, const GLushort *addr);
typedef void (APIENTRYP PFNGLVARIANTUIVEXTPROC) (GLuint id, const GLuint *addr);
typedef void (APIENTRYP PFNGLVARIANTPOINTEREXTPROC) (GLuint id, GLenum type, GLuint stride, const void *addr);
typedef void (APIENTRYP PFNGLENABLEVARIANTCLIENTSTATEEXTPROC) (GLuint id);
typedef void (APIENTRYP PFNGLDISABLEVARIANTCLIENTSTATEEXTPROC) (GLuint id);
typedef GLuint (APIENTRYP PFNGLBINDLIGHTPARAMETEREXTPROC) (GLenum light, GLenum value);
typedef GLuint (APIENTRYP PFNGLBINDMATERIALPARAMETEREXTPROC) (GLenum face, GLenum value);
typedef GLuint (APIENTRYP PFNGLBINDTEXGENPARAMETEREXTPROC) (GLenum unit, GLenum coord, GLenum value);
typedef GLuint (APIENTRYP PFNGLBINDTEXTUREUNITPARAMETEREXTPROC) (GLenum unit, GLenum value);
typedef GLuint (APIENTRYP PFNGLBINDPARAMETEREXTPROC) (GLenum value);
typedef GLboolean (APIENTRYP PFNGLISVARIANTENABLEDEXTPROC) (GLuint id, GLenum cap);
typedef void (APIENTRYP PFNGLGETVARIANTBOOLEANVEXTPROC) (GLuint id, GLenum value, GLboolean *data);
typedef void (APIENTRYP PFNGLGETVARIANTINTEGERVEXTPROC) (GLuint id, GLenum value, GLint *data);
typedef void (APIENTRYP PFNGLGETVARIANTFLOATVEXTPROC) (GLuint id, GLenum value, GLfloat *data);
typedef void (APIENTRYP PFNGLGETVARIANTPOINTERVEXTPROC) (GLuint id, GLenum value, void **data);
typedef void (APIENTRYP PFNGLGETINVARIANTBOOLEANVEXTPROC) (GLuint id, GLenum value, GLboolean *data);
typedef void (APIENTRYP PFNGLGETINVARIANTINTEGERVEXTPROC) (GLuint id, GLenum value, GLint *data);
typedef void (APIENTRYP PFNGLGETINVARIANTFLOATVEXTPROC) (GLuint id, GLenum value, GLfloat *data);
typedef void (APIENTRYP PFNGLGETLOCALCONSTANTBOOLEANVEXTPROC) (GLuint id, GLenum value, GLboolean *data);
typedef void (APIENTRYP PFNGLGETLOCALCONSTANTINTEGERVEXTPROC) (GLuint id, GLenum value, GLint *data);
typedef void (APIENTRYP PFNGLGETLOCALCONSTANTFLOATVEXTPROC) (GLuint id, GLenum value, GLfloat *data);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glBeginVertexShaderEXT (void);
GLAPI void APIENTRY glEndVertexShaderEXT (void);
GLAPI void APIENTRY glBindVertexShaderEXT (GLuint id);
GLAPI GLuint APIENTRY glGenVertexShadersEXT (GLuint range);
GLAPI void APIENTRY glDeleteVertexShaderEXT (GLuint id);
GLAPI void APIENTRY glShaderOp1EXT (GLenum op, GLuint res, GLuint arg1);
GLAPI void APIENTRY glShaderOp2EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2);
GLAPI void APIENTRY glShaderOp3EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);
GLAPI void APIENTRY glSwizzleEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
GLAPI void APIENTRY glWriteMaskEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
GLAPI void APIENTRY glInsertComponentEXT (GLuint res, GLuint src, GLuint num);
GLAPI void APIENTRY glExtractComponentEXT (GLuint res, GLuint src, GLuint num);
GLAPI GLuint APIENTRY glGenSymbolsEXT (GLenum datatype, GLenum storagetype, GLenum range, GLuint components);
GLAPI void APIENTRY glSetInvariantEXT (GLuint id, GLenum type, const void *addr);
GLAPI void APIENTRY glSetLocalConstantEXT (GLuint id, GLenum type, const void *addr);
GLAPI void APIENTRY glVariantbvEXT (GLuint id, const GLbyte *addr);
GLAPI void APIENTRY glVariantsvEXT (GLuint id, const GLshort *addr);
GLAPI void APIENTRY glVariantivEXT (GLuint id, const GLint *addr);
GLAPI void APIENTRY glVariantfvEXT (GLuint id, const GLfloat *addr);
GLAPI void APIENTRY glVariantdvEXT (GLuint id, const GLdouble *addr);
GLAPI void APIENTRY glVariantubvEXT (GLuint id, const GLubyte *addr);
GLAPI void APIENTRY glVariantusvEXT (GLuint id, const GLushort *addr);
GLAPI void APIENTRY glVariantuivEXT (GLuint id, const GLuint *addr);
GLAPI void APIENTRY glVariantPointerEXT (GLuint id, GLenum type, GLuint stride, const void *addr);
GLAPI void APIENTRY glEnableVariantClientStateEXT (GLuint id);
GLAPI void APIENTRY glDisableVariantClientStateEXT (GLuint id);
GLAPI GLuint APIENTRY glBindLightParameterEXT (GLenum light, GLenum value);
GLAPI GLuint APIENTRY glBindMaterialParameterEXT (GLenum face, GLenum value);
GLAPI GLuint APIENTRY glBindTexGenParameterEXT (GLenum unit, GLenum coord, GLenum value);
GLAPI GLuint APIENTRY glBindTextureUnitParameterEXT (GLenum unit, GLenum value);
GLAPI GLuint APIENTRY glBindParameterEXT (GLenum value);
GLAPI GLboolean APIENTRY glIsVariantEnabledEXT (GLuint id, GLenum cap);
GLAPI void APIENTRY glGetVariantBooleanvEXT (GLuint id, GLenum value, GLboolean *data);
GLAPI void APIENTRY glGetVariantIntegervEXT (GLuint id, GLenum value, GLint *data);
GLAPI void APIENTRY glGetVariantFloatvEXT (GLuint id, GLenum value, GLfloat *data);
GLAPI void APIENTRY glGetVariantPointervEXT (GLuint id, GLenum value, void **data);
GLAPI void APIENTRY glGetInvariantBooleanvEXT (GLuint id, GLenum value, GLboolean *data);
GLAPI void APIENTRY glGetInvariantIntegervEXT (GLuint id, GLenum value, GLint *data);
GLAPI void APIENTRY glGetInvariantFloatvEXT (GLuint id, GLenum value, GLfloat *data);
GLAPI void APIENTRY glGetLocalConstantBooleanvEXT (GLuint id, GLenum value, GLboolean *data);
GLAPI void APIENTRY glGetLocalConstantIntegervEXT (GLuint id, GLenum value, GLint *data);
GLAPI void APIENTRY glGetLocalConstantFloatvEXT (GLuint id, GLenum value, GLfloat *data);
#endif
#endif /* GL_EXT_vertex_shader */

#ifndef GL_EXT_vertex_weighting
#define GL_EXT_vertex_weighting 1
#define GL_MODELVIEW0_STACK_DEPTH_EXT     0x0BA3
#define GL_MODELVIEW1_STACK_DEPTH_EXT     0x8502
#define GL_MODELVIEW0_MATRIX_EXT          0x0BA6
#define GL_MODELVIEW1_MATRIX_EXT          0x8506
#define GL_VERTEX_WEIGHTING_EXT           0x8509
#define GL_MODELVIEW0_EXT                 0x1700
#define GL_MODELVIEW1_EXT                 0x850A
#define GL_CURRENT_VERTEX_WEIGHT_EXT      0x850B
#define GL_VERTEX_WEIGHT_ARRAY_EXT        0x850C
#define GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT   0x850D
#define GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT   0x850E
#define GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT 0x850F
#define GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT 0x8510
typedef void (APIENTRYP PFNGLVERTEXWEIGHTFEXTPROC) (GLfloat weight);
typedef void (APIENTRYP PFNGLVERTEXWEIGHTFVEXTPROC) (const GLfloat *weight);
typedef void (APIENTRYP PFNGLVERTEXWEIGHTPOINTEREXTPROC) (GLint size, GLenum type, GLsizei stride, const void *pointer);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glVertexWeightfEXT (GLfloat weight);
GLAPI void APIENTRY glVertexWeightfvEXT (const GLfloat *weight);
GLAPI void APIENTRY glVertexWeightPointerEXT (GLint size, GLenum type, GLsizei stride, const void *pointer);
#endif
#endif /* GL_EXT_vertex_weighting */

#ifndef GL_EXT_window_rectangles
#define GL_EXT_window_rectangles 1
#define GL_INCLUSIVE_EXT                  0x8F10
#define GL_EXCLUSIVE_EXT                  0x8F11
#define GL_WINDOW_RECTANGLE_EXT           0x8F12
#define GL_WINDOW_RECTANGLE_MODE_EXT      0x8F13
#define GL_MAX_WINDOW_RECTANGLES_EXT      0x8F14
#define GL_NUM_WINDOW_RECTANGLES_EXT      0x8F15
typedef void (APIENTRYP PFNGLWINDOWRECTANGLESEXTPROC) (GLenum mode, GLsizei count, const GLint *box);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glWindowRectanglesEXT (GLenum mode, GLsizei count, const GLint *box);
#endif
#endif /* GL_EXT_window_rectangles */

#ifndef GL_EXT_x11_sync_object
#define GL_EXT_x11_sync_object 1
#define GL_SYNC_X11_FENCE_EXT             0x90E1
typedef GLsync (APIENTRYP PFNGLIMPORTSYNCEXTPROC) (GLenum external_sync_type, GLintptr external_sync, GLbitfield flags);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI GLsync APIENTRY glImportSyncEXT (GLenum external_sync_type, GLintptr external_sync, GLbitfield flags);
#endif
#endif /* GL_EXT_x11_sync_object */

#ifndef GL_GREMEDY_frame_terminator
#define GL_GREMEDY_frame_terminator 1
typedef void (APIENTRYP PFNGLFRAMETERMINATORGREMEDYPROC) (void);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glFrameTerminatorGREMEDY (void);
#endif
#endif /* GL_GREMEDY_frame_terminator */

#ifndef GL_GREMEDY_string_marker
#define GL_GREMEDY_string_marker 1
typedef void (APIENTRYP PFNGLSTRINGMARKERGREMEDYPROC) (GLsizei len, const void *string);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glStringMarkerGREMEDY (GLsizei len, const void *string);
#endif
#endif /* GL_GREMEDY_string_marker */

#ifndef GL_HP_convolution_border_modes
#define GL_HP_convolution_border_modes 1
#define GL_IGNORE_BORDER_HP               0x8150
#define GL_CONSTANT_BORDER_HP             0x8151
#define GL_REPLICATE_BORDER_HP            0x8153
#define GL_CONVOLUTION_BORDER_COLOR_HP    0x8154
#endif /* GL_HP_convolution_border_modes */

#ifndef GL_HP_image_transform
#define GL_HP_image_transform 1
#define GL_IMAGE_SCALE_X_HP               0x8155
#define GL_IMAGE_SCALE_Y_HP               0x8156
#define GL_IMAGE_TRANSLATE_X_HP           0x8157
#define GL_IMAGE_TRANSLATE_Y_HP           0x8158
#define GL_IMAGE_ROTATE_ANGLE_HP          0x8159
#define GL_IMAGE_ROTATE_ORIGIN_X_HP       0x815A
#define GL_IMAGE_ROTATE_ORIGIN_Y_HP       0x815B
#define GL_IMAGE_MAG_FILTER_HP            0x815C
#define GL_IMAGE_MIN_FILTER_HP            0x815D
#define GL_IMAGE_CUBIC_WEIGHT_HP          0x815E
#define GL_CUBIC_HP                       0x815F
#define GL_AVERAGE_HP                     0x8160
#define GL_IMAGE_TRANSFORM_2D_HP          0x8161
#define GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP 0x8162
#define GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP 0x8163
typedef void (APIENTRYP PFNGLIMAGETRANSFORMPARAMETERIHPPROC) (GLenum target, GLenum pname, GLint param);
typedef void (APIENTRYP PFNGLIMAGETRANSFORMPARAMETERFHPPROC) (GLenum target, GLenum pname, GLfloat param);
typedef void (APIENTRYP PFNGLIMAGETRANSFORMPARAMETERIVHPPROC) (GLenum target, GLenum pname, const GLint *params);
typedef void (APIENTRYP PFNGLIMAGETRANSFORMPARAMETERFVHPPROC) (GLenum target, GLenum pname, const GLfloat *params);
typedef void (APIENTRYP PFNGLGETIMAGETRANSFORMPARAMETERIVHPPROC) (GLenum target, GLenum pname, GLint *params);
typedef void (APIENTRYP PFNGLGETIMAGETRANSFORMPARAMETERFVHPPROC) (GLenum target, GLenum pname, GLfloat *params);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glImageTransformParameteriHP (GLenum target, GLenum pname, GLint param);
GLAPI void APIENTRY glImageTransformParameterfHP (GLenum target, GLenum pname, GLfloat param);
GLAPI void APIENTRY glImageTransformParameterivHP (GLenum target, GLenum pname, const GLint *params);
GLAPI void APIENTRY glImageTransformParameterfvHP (GLenum target, GLenum pname, const GLfloat *params);
GLAPI void APIENTRY glGetImageTransformParameterivHP (GLenum target, GLenum pname, GLint *params);
GLAPI void APIENTRY glGetImageTransformParameterfvHP (GLenum target, GLenum pname, GLfloat *params);
#endif
#endif /* GL_HP_image_transform */

#ifndef GL_HP_occlusion_test
#define GL_HP_occlusion_test 1
#define GL_OCCLUSION_TEST_HP              0x8165
#define GL_OCCLUSION_TEST_RESULT_HP       0x8166
#endif /* GL_HP_occlusion_test */

#ifndef GL_HP_texture_lighting
#define GL_HP_texture_lighting 1
#define GL_TEXTURE_LIGHTING_MODE_HP       0x8167
#define GL_TEXTURE_POST_SPECULAR_HP       0x8168
#define GL_TEXTURE_PRE_SPECULAR_HP        0x8169
#endif /* GL_HP_texture_lighting */

#ifndef GL_IBM_cull_vertex
#define GL_IBM_cull_vertex 1
#define GL_CULL_VERTEX_IBM                103050
#endif /* GL_IBM_cull_vertex */

#ifndef GL_IBM_multimode_draw_arrays
#define GL_IBM_multimode_draw_arrays 1
typedef void (APIENTRYP PFNGLMULTIMODEDRAWARRAYSIBMPROC) (const GLenum *mode, const GLint *first, const GLsizei *count, GLsizei primcount, GLint modestride);
typedef void (APIENTRYP PFNGLMULTIMODEDRAWELEMENTSIBMPROC) (const GLenum *mode, const GLsizei *count, GLenum type, const void *const*indices, GLsizei primcount, GLint modestride);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glMultiModeDrawArraysIBM (const GLenum *mode, const GLint *first, const GLsizei *count, GLsizei primcount, GLint modestride);
GLAPI void APIENTRY glMultiModeDrawElementsIBM (const GLenum *mode, const GLsizei *count, GLenum type, const void *const*indices, GLsizei primcount, GLint modestride);
#endif
#endif /* GL_IBM_multimode_draw_arrays */

#ifndef GL_IBM_rasterpos_clip
#define GL_IBM_rasterpos_clip 1
#define GL_RASTER_POSITION_UNCLIPPED_IBM  0x19262
#endif /* GL_IBM_rasterpos_clip */

#ifndef GL_IBM_static_data
#define GL_IBM_static_data 1
#define GL_ALL_STATIC_DATA_IBM            103060
#define GL_STATIC_VERTEX_ARRAY_IBM        103061
typedef void (APIENTRYP PFNGLFLUSHSTATICDATAIBMPROC) (GLenum target);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glFlushStaticDataIBM (GLenum target);
#endif
#endif /* GL_IBM_static_data */

#ifndef GL_IBM_texture_mirrored_repeat
#define GL_IBM_texture_mirrored_repeat 1
#define GL_MIRRORED_REPEAT_IBM            0x8370
#endif /* GL_IBM_texture_mirrored_repeat */

#ifndef GL_IBM_vertex_array_lists
#define GL_IBM_vertex_array_lists 1
#define GL_VERTEX_ARRAY_LIST_IBM          103070
#define GL_NORMAL_ARRAY_LIST_IBM          103071
#define GL_COLOR_ARRAY_LIST_IBM           103072
#define GL_INDEX_ARRAY_LIST_IBM           103073
#define GL_TEXTURE_COORD_ARRAY_LIST_IBM   103074
#define GL_EDGE_FLAG_ARRAY_LIST_IBM       103075
#define GL_FOG_COORDINATE_ARRAY_LIST_IBM  103076
#define GL_SECONDARY_COLOR_ARRAY_LIST_IBM 103077
#define GL_VERTEX_ARRAY_LIST_STRIDE_IBM   103080
#define GL_NORMAL_ARRAY_LIST_STRIDE_IBM   103081
#define GL_COLOR_ARRAY_LIST_STRIDE_IBM    103082
#define GL_INDEX_ARRAY_LIST_STRIDE_IBM    103083
#define GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM 103084
#define GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM 103085
#define GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM 103086
#define GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM 103087
typedef void (APIENTRYP PFNGLCOLORPOINTERLISTIBMPROC) (GLint size, GLenum type, GLint stride, const void **pointer, GLint ptrstride);
typedef void (APIENTRYP PFNGLSECONDARYCOLORPOINTERLISTIBMPROC) (GLint size, GLenum type, GLint stride, const void **pointer, GLint ptrstride);
typedef void (APIENTRYP PFNGLEDGEFLAGPOINTERLISTIBMPROC) (GLint stride, const GLboolean **pointer, GLint ptrstride);
typedef void (APIENTRYP PFNGLFOGCOORDPOINTERLISTIBMPROC) (GLenum type, GLint stride, const void **pointer, GLint ptrstride);
typedef void (APIENTRYP PFNGLINDEXPOINTERLISTIBMPROC) (GLenum type, GLint stride, const void **pointer, GLint ptrstride);
typedef void (APIENTRYP PFNGLNORMALPOINTERLISTIBMPROC) (GLenum type, GLint stride, const void **pointer, GLint ptrstride);
typedef void (APIENTRYP PFNGLTEXCOORDPOINTERLISTIBMPROC) (GLint size, GLenum type, GLint stride, const void **pointer, GLint ptrstride);
typedef void (APIENTRYP PFNGLVERTEXPOINTERLISTIBMPROC) (GLint size, GLenum type, GLint stride, const void **pointer, GLint ptrstride);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glColorPointerListIBM (GLint size, GLenum type, GLint stride, const void **pointer, GLint ptrstride);
GLAPI void APIENTRY glSecondaryColorPointerListIBM (GLint size, GLenum type, GLint stride, const void **pointer, GLint ptrstride);
GLAPI void APIENTRY glEdgeFlagPointerListIBM (GLint stride, const GLboolean **pointer, GLint ptrstride);
GLAPI void APIENTRY glFogCoordPointerListIBM (GLenum type, GLint stride, const void **pointer, GLint ptrstride);
GLAPI void APIENTRY glIndexPointerListIBM (GLenum type, GLint stride, const void **pointer, GLint ptrstride);
GLAPI void APIENTRY glNormalPointerListIBM (GLenum type, GLint stride, const void **pointer, GLint ptrstride);
GLAPI void APIENTRY glTexCoordPointerListIBM (GLint size, GLenum type, GLint stride, const void **pointer, GLint ptrstride);
GLAPI void APIENTRY glVertexPointerListIBM (GLint size, GLenum type, GLint stride, const void **pointer, GLint ptrstride);
#endif
#endif /* GL_IBM_vertex_array_lists */

#ifndef GL_INGR_blend_func_separate
#define GL_INGR_blend_func_separate 1
typedef void (APIENTRYP PFNGLBLENDFUNCSEPARATEINGRPROC) (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glBlendFuncSeparateINGR (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
#endif
#endif /* GL_INGR_blend_func_separate */

#ifndef GL_INGR_color_clamp
#define GL_INGR_color_clamp 1
#define GL_RED_MIN_CLAMP_INGR             0x8560
#define GL_GREEN_MIN_CLAMP_INGR           0x8561
#define GL_BLUE_MIN_CLAMP_INGR            0x8562
#define GL_ALPHA_MIN_CLAMP_INGR           0x8563
#define GL_RED_MAX_CLAMP_INGR             0x8564
#define GL_GREEN_MAX_CLAMP_INGR           0x8565
#define GL_BLUE_MAX_CLAMP_INGR            0x8566
#define GL_ALPHA_MAX_CLAMP_INGR           0x8567
#endif /* GL_INGR_color_clamp */

#ifndef GL_INGR_interlace_read
#define GL_INGR_interlace_read 1
#define GL_INTERLACE_READ_INGR            0x8568
#endif /* GL_INGR_interlace_read */

#ifndef GL_INTEL_conservative_rasterization
#define GL_INTEL_conservative_rasterization 1
#define GL_CONSERVATIVE_RASTERIZATION_INTEL 0x83FE
#endif /* GL_INTEL_conservative_rasterization */

#ifndef GL_INTEL_fragment_shader_ordering
#define GL_INTEL_fragment_shader_ordering 1
#endif /* GL_INTEL_fragment_shader_ordering */

#ifndef GL_INTEL_framebuffer_CMAA
#define GL_INTEL_framebuffer_CMAA 1
typedef void (APIENTRYP PFNGLAPPLYFRAMEBUFFERATTACHMENTCMAAINTELPROC) (void);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glApplyFramebufferAttachmentCMAAINTEL (void);
#endif
#endif /* GL_INTEL_framebuffer_CMAA */

#ifndef GL_INTEL_map_texture
#define GL_INTEL_map_texture 1
#define GL_TEXTURE_MEMORY_LAYOUT_INTEL    0x83FF
#define GL_LAYOUT_DEFAULT_INTEL           0
#define GL_LAYOUT_LINEAR_INTEL            1
#define GL_LAYOUT_LINEAR_CPU_CACHED_INTEL 2
typedef void (APIENTRYP PFNGLSYNCTEXTUREINTELPROC) (GLuint texture);
typedef void (APIENTRYP PFNGLUNMAPTEXTURE2DINTELPROC) (GLuint texture, GLint level);
typedef void *(APIENTRYP PFNGLMAPTEXTURE2DINTELPROC) (GLuint texture, GLint level, GLbitfield access, GLint *stride, GLenum *layout);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glSyncTextureINTEL (GLuint texture);
GLAPI void APIENTRY glUnmapTexture2DINTEL (GLuint texture, GLint level);
GLAPI void *APIENTRY glMapTexture2DINTEL (GLuint texture, GLint level, GLbitfield access, GLint *stride, GLenum *layout);
#endif
#endif /* GL_INTEL_map_texture */

#ifndef GL_INTEL_parallel_arrays
#define GL_INTEL_parallel_arrays 1
#define GL_PARALLEL_ARRAYS_INTEL          0x83F4
#define GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL 0x83F5
#define GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL 0x83F6
#define GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL 0x83F7
#define GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL 0x83F8
typedef void (APIENTRYP PFNGLVERTEXPOINTERVINTELPROC) (GLint size, GLenum type, const void **pointer);
typedef void (APIENTRYP PFNGLNORMALPOINTERVINTELPROC) (GLenum type, const void **pointer);
typedef void (APIENTRYP PFNGLCOLORPOINTERVINTELPROC) (GLint size, GLenum type, const void **pointer);
typedef void (APIENTRYP PFNGLTEXCOORDPOINTERVINTELPROC) (GLint size, GLenum type, const void **pointer);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glVertexPointervINTEL (GLint size, GLenum type, const void **pointer);
GLAPI void APIENTRY glNormalPointervINTEL (GLenum type, const void **pointer);
GLAPI void APIENTRY glColorPointervINTEL (GLint size, GLenum type, const void **pointer);
GLAPI void APIENTRY glTexCoordPointervINTEL (GLint size, GLenum type, const void **pointer);
#endif
#endif /* GL_INTEL_parallel_arrays */

#ifndef GL_INTEL_performance_query
#define GL_INTEL_performance_query 1
#define GL_PERFQUERY_SINGLE_CONTEXT_INTEL 0x00000000
#define GL_PERFQUERY_GLOBAL_CONTEXT_INTEL 0x00000001
#define GL_PERFQUERY_WAIT_INTEL           0x83FB
#define GL_PERFQUERY_FLUSH_INTEL          0x83FA
#define GL_PERFQUERY_DONOT_FLUSH_INTEL    0x83F9
#define GL_PERFQUERY_COUNTER_EVENT_INTEL  0x94F0
#define GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL 0x94F1
#define GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL 0x94F2
#define GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL 0x94F3
#define GL_PERFQUERY_COUNTER_RAW_INTEL    0x94F4
#define GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL 0x94F5
#define GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL 0x94F8
#define GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL 0x94F9
#define GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL 0x94FA
#define GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL 0x94FB
#define GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL 0x94FC
#define GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL 0x94FD
#define GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL 0x94FE
#define GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL 0x94FF
#define GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL 0x9500
typedef void (APIENTRYP PFNGLBEGINPERFQUERYINTELPROC) (GLuint queryHandle);
typedef void (APIENTRYP PFNGLCREATEPERFQUERYINTELPROC) (GLuint queryId, GLuint *queryHandle);
typedef void (APIENTRYP PFNGLDELETEPERFQUERYINTELPROC) (GLuint queryHandle);
typedef void (APIENTRYP PFNGLENDPERFQUERYINTELPROC) (GLuint queryHandle);
typedef void (APIENTRYP PFNGLGETFIRSTPERFQUERYIDINTELPROC) (GLuint *queryId);
typedef void (APIENTRYP PFNGLGETNEXTPERFQUERYIDINTELPROC) (GLuint queryId, GLuint *nextQueryId);
typedef void (APIENTRYP PFNGLGETPERFCOUNTERINFOINTELPROC) (GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar *counterName, GLuint counterDescLength, GLchar *counterDesc, GLuint *counterOffset, GLuint *counterDataSize, GLuint *counterTypeEnum, GLuint *counterDataTypeEnum, GLuint64 *rawCounterMaxValue);
typedef void (APIENTRYP PFNGLGETPERFQUERYDATAINTELPROC) (GLuint queryHandle, GLuint flags, GLsizei dataSize, GLvoid *data, GLuint *bytesWritten);
typedef void (APIENTRYP PFNGLGETPERFQUERYIDBYNAMEINTELPROC) (GLchar *queryName, GLuint *queryId);
typedef void (APIENTRYP PFNGLGETPERFQUERYINFOINTELPROC) (GLuint queryId, GLuint queryNameLength, GLchar *queryName, GLuint *dataSize, GLuint *noCounters, GLuint *noInstances, GLuint *capsMask);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glBeginPerfQueryINTEL (GLuint queryHandle);
GLAPI void APIENTRY glCreatePerfQueryINTEL (GLuint queryId, GLuint *queryHandle);
GLAPI void APIENTRY glDeletePerfQueryINTEL (GLuint queryHandle);
GLAPI void APIENTRY glEndPerfQueryINTEL (GLuint queryHandle);
GLAPI void APIENTRY glGetFirstPerfQueryIdINTEL (GLuint *queryId);
GLAPI void APIENTRY glGetNextPerfQueryIdINTEL (GLuint queryId, GLuint *nextQueryId);
GLAPI void APIENTRY glGetPerfCounterInfoINTEL (GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar *counterName, GLuint counterDescLength, GLchar *counterDesc, GLuint *counterOffset, GLuint *counterDataSize, GLuint *counterTypeEnum, GLuint *counterDataTypeEnum, GLuint64 *rawCounterMaxValue);
GLAPI void APIENTRY glGetPerfQueryDataINTEL (GLuint queryHandle, GLuint flags, GLsizei dataSize, GLvoid *data, GLuint *bytesWritten);
GLAPI void APIENTRY glGetPerfQueryIdByNameINTEL (GLchar *queryName, GLuint *queryId);
GLAPI void APIENTRY glGetPerfQueryInfoINTEL (GLuint queryId, GLuint queryNameLength, GLchar *queryName, GLuint *dataSize, GLuint *noCounters, GLuint *noInstances, GLuint *capsMask);
#endif
#endif /* GL_INTEL_performance_query */

#ifndef GL_MESAX_texture_stack
#define GL_MESAX_texture_stack 1
#define GL_TEXTURE_1D_STACK_MESAX         0x8759
#define GL_TEXTURE_2D_STACK_MESAX         0x875A
#define GL_PROXY_TEXTURE_1D_STACK_MESAX   0x875B
#define GL_PROXY_TEXTURE_2D_STACK_MESAX   0x875C
#define GL_TEXTURE_1D_STACK_BINDING_MESAX 0x875D
#define GL_TEXTURE_2D_STACK_BINDING_MESAX 0x875E
#endif /* GL_MESAX_texture_stack */

#ifndef GL_MESA_pack_invert
#define GL_MESA_pack_invert 1
#define GL_PACK_INVERT_MESA               0x8758
#endif /* GL_MESA_pack_invert */

#ifndef GL_MESA_resize_buffers
#define GL_MESA_resize_buffers 1
typedef void (APIENTRYP PFNGLRESIZEBUFFERSMESAPROC) (void);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glResizeBuffersMESA (void);
#endif
#endif /* GL_MESA_resize_buffers */

#ifndef GL_MESA_window_pos
#define GL_MESA_window_pos 1
typedef void (APIENTRYP PFNGLWINDOWPOS2DMESAPROC) (GLdouble x, GLdouble y);
typedef void (APIENTRYP PFNGLWINDOWPOS2DVMESAPROC) (const GLdouble *v);
typedef void (APIENTRYP PFNGLWINDOWPOS2FMESAPROC) (GLfloat x, GLfloat y);
typedef void (APIENTRYP PFNGLWINDOWPOS2FVMESAPROC) (const GLfloat *v);
typedef void (APIENTRYP PFNGLWINDOWPOS2IMESAPROC) (GLint x, GLint y);
typedef void (APIENTRYP PFNGLWINDOWPOS2IVMESAPROC) (const GLint *v);
typedef void (APIENTRYP PFNGLWINDOWPOS2SMESAPROC) (GLshort x, GLshort y);
typedef void (APIENTRYP PFNGLWINDOWPOS2SVMESAPROC) (const GLshort *v);
typedef void (APIENTRYP PFNGLWINDOWPOS3DMESAPROC) (GLdouble x, GLdouble y, GLdouble z);
typedef void (APIENTRYP PFNGLWINDOWPOS3DVMESAPROC) (const GLdouble *v);
typedef void (APIENTRYP PFNGLWINDOWPOS3FMESAPROC) (GLfloat x, GLfloat y, GLfloat z);
typedef void (APIENTRYP PFNGLWINDOWPOS3FVMESAPROC) (const GLfloat *v);
typedef void (APIENTRYP PFNGLWINDOWPOS3IMESAPROC) (GLint x, GLint y, GLint z);
typedef void (APIENTRYP PFNGLWINDOWPOS3IVMESAPROC) (const GLint *v);
typedef void (APIENTRYP PFNGLWINDOWPOS3SMESAPROC) (GLshort x, GLshort y, GLshort z);
typedef void (APIENTRYP PFNGLWINDOWPOS3SVMESAPROC) (const GLshort *v);
typedef void (APIENTRYP PFNGLWINDOWPOS4DMESAPROC) (GLdouble x, GLdouble y, GLdouble z, GLdouble w);
typedef void (APIENTRYP PFNGLWINDOWPOS4DVMESAPROC) (const GLdouble *v);
typedef void (APIENTRYP PFNGLWINDOWPOS4FMESAPROC) (GLfloat x, GLfloat y, GLfloat z, GLfloat w);
typedef void (APIENTRYP PFNGLWINDOWPOS4FVMESAPROC) (const GLfloat *v);
typedef void (APIENTRYP PFNGLWINDOWPOS4IMESAPROC) (GLint x, GLint y, GLint z, GLint w);
typedef void (APIENTRYP PFNGLWINDOWPOS4IVMESAPROC) (const GLint *v);
typedef void (APIENTRYP PFNGLWINDOWPOS4SMESAPROC) (GLshort x, GLshort y, GLshort z, GLshort w);
typedef void (APIENTRYP PFNGLWINDOWPOS4SVMESAPROC) (const GLshort *v);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glWindowPos2dMESA (GLdouble x, GLdouble y);
GLAPI void APIENTRY glWindowPos2dvMESA (const GLdouble *v);
GLAPI void APIENTRY glWindowPos2fMESA (GLfloat x, GLfloat y);
GLAPI void APIENTRY glWindowPos2fvMESA (const GLfloat *v);
GLAPI void APIENTRY glWindowPos2iMESA (GLint x, GLint y);
GLAPI void APIENTRY glWindowPos2ivMESA (const GLint *v);
GLAPI void APIENTRY glWindowPos2sMESA (GLshort x, GLshort y);
GLAPI void APIENTRY glWindowPos2svMESA (const GLshort *v);
GLAPI void APIENTRY glWindowPos3dMESA (GLdouble x, GLdouble y, GLdouble z);
GLAPI void APIENTRY glWindowPos3dvMESA (const GLdouble *v);
GLAPI void APIENTRY glWindowPos3fMESA (GLfloat x, GLfloat y, GLfloat z);
GLAPI void APIENTRY glWindowPos3fvMESA (const GLfloat *v);
GLAPI void APIENTRY glWindowPos3iMESA (GLint x, GLint y, GLint z);
GLAPI void APIENTRY glWindowPos3ivMESA (const GLint *v);
GLAPI void APIENTRY glWindowPos3sMESA (GLshort x, GLshort y, GLshort z);
GLAPI void APIENTRY glWindowPos3svMESA (const GLshort *v);
GLAPI void APIENTRY glWindowPos4dMESA (GLdouble x, GLdouble y, GLdouble z, GLdouble w);
GLAPI void APIENTRY glWindowPos4dvMESA (const GLdouble *v);
GLAPI void APIENTRY glWindowPos4fMESA (GLfloat x, GLfloat y, GLfloat z, GLfloat w);
GLAPI void APIENTRY glWindowPos4fvMESA (const GLfloat *v);
GLAPI void APIENTRY glWindowPos4iMESA (GLint x, GLint y, GLint z, GLint w);
GLAPI void APIENTRY glWindowPos4ivMESA (const GLint *v);
GLAPI void APIENTRY glWindowPos4sMESA (GLshort x, GLshort y, GLshort z, GLshort w);
GLAPI void APIENTRY glWindowPos4svMESA (const GLshort *v);
#endif
#endif /* GL_MESA_window_pos */

#ifndef GL_MESA_ycbcr_texture
#define GL_MESA_ycbcr_texture 1
#define GL_UNSIGNED_SHORT_8_8_MESA        0x85BA
#define GL_UNSIGNED_SHORT_8_8_REV_MESA    0x85BB
#define GL_YCBCR_MESA                     0x8757
#endif /* GL_MESA_ycbcr_texture */

#ifndef GL_NVX_conditional_render
#define GL_NVX_conditional_render 1
typedef void (APIENTRYP PFNGLBEGINCONDITIONALRENDERNVXPROC) (GLuint id);
typedef void (APIENTRYP PFNGLENDCONDITIONALRENDERNVXPROC) (void);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glBeginConditionalRenderNVX (GLuint id);
GLAPI void APIENTRY glEndConditionalRenderNVX (void);
#endif
#endif /* GL_NVX_conditional_render */

#ifndef GL_NVX_gpu_memory_info
#define GL_NVX_gpu_memory_info 1
#define GL_GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX 0x9047
#define GL_GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX 0x9048
#define GL_GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX 0x9049
#define GL_GPU_MEMORY_INFO_EVICTION_COUNT_NVX 0x904A
#define GL_GPU_MEMORY_INFO_EVICTED_MEMORY_NVX 0x904B
#endif /* GL_NVX_gpu_memory_info */

#ifndef GL_NV_bindless_multi_draw_indirect
#define GL_NV_bindless_multi_draw_indirect 1
typedef void (APIENTRYP PFNGLMULTIDRAWARRAYSINDIRECTBINDLESSNVPROC) (GLenum mode, const void *indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);
typedef void (APIENTRYP PFNGLMULTIDRAWELEMENTSINDIRECTBINDLESSNVPROC) (GLenum mode, GLenum type, const void *indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glMultiDrawArraysIndirectBindlessNV (GLenum mode, const void *indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);
GLAPI void APIENTRY glMultiDrawElementsIndirectBindlessNV (GLenum mode, GLenum type, const void *indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);
#endif
#endif /* GL_NV_bindless_multi_draw_indirect */

#ifndef GL_NV_bindless_multi_draw_indirect_count
#define GL_NV_bindless_multi_draw_indirect_count 1
typedef void (APIENTRYP PFNGLMULTIDRAWARRAYSINDIRECTBINDLESSCOUNTNVPROC) (GLenum mode, const void *indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);
typedef void (APIENTRYP PFNGLMULTIDRAWELEMENTSINDIRECTBINDLESSCOUNTNVPROC) (GLenum mode, GLenum type, const void *indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glMultiDrawArraysIndirectBindlessCountNV (GLenum mode, const void *indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);
GLAPI void APIENTRY glMultiDrawElementsIndirectBindlessCountNV (GLenum mode, GLenum type, const void *indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);
#endif
#endif /* GL_NV_bindless_multi_draw_indirect_count */

#ifndef GL_NV_bindless_texture
#define GL_NV_bindless_texture 1
typedef GLuint64 (APIENTRYP PFNGLGETTEXTUREHANDLENVPROC) (GLuint texture);
typedef GLuint64 (APIENTRYP PFNGLGETTEXTURESAMPLERHANDLENVPROC) (GLuint texture, GLuint sampler);
typedef void (APIENTRYP PFNGLMAKETEXTUREHANDLERESIDENTNVPROC) (GLuint64 handle);
typedef void (APIENTRYP PFNGLMAKETEXTUREHANDLENONRESIDENTNVPROC) (GLuint64 handle);
typedef GLuint64 (APIENTRYP PFNGLGETIMAGEHANDLENVPROC) (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);
typedef void (APIENTRYP PFNGLMAKEIMAGEHANDLERESIDENTNVPROC) (GLuint64 handle, GLenum access);
typedef void (APIENTRYP PFNGLMAKEIMAGEHANDLENONRESIDENTNVPROC) (GLuint64 handle);
typedef void (APIENTRYP PFNGLUNIFORMHANDLEUI64NVPROC) (GLint location, GLuint64 value);
typedef void (APIENTRYP PFNGLUNIFORMHANDLEUI64VNVPROC) (GLint location, GLsizei count, const GLuint64 *value);
typedef void (APIENTRYP PFNGLPROGRAMUNIFORMHANDLEUI64NVPROC) (GLuint program, GLint location, GLuint64 value);
typedef void (APIENTRYP PFNGLPROGRAMUNIFORMHANDLEUI64VNVPROC) (GLuint program, GLint location, GLsizei count, const GLuint64 *values);
typedef GLboolean (APIENTRYP PFNGLISTEXTUREHANDLERESIDENTNVPROC) (GLuint64 handle);
typedef GLboolean (APIENTRYP PFNGLISIMAGEHANDLERESIDENTNVPROC) (GLuint64 handle);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI GLuint64 APIENTRY glGetTextureHandleNV (GLuint texture);
GLAPI GLuint64 APIENTRY glGetTextureSamplerHandleNV (GLuint texture, GLuint sampler);
GLAPI void APIENTRY glMakeTextureHandleResidentNV (GLuint64 handle);
GLAPI void APIENTRY glMakeTextureHandleNonResidentNV (GLuint64 handle);
GLAPI GLuint64 APIENTRY glGetImageHandleNV (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);
GLAPI void APIENTRY glMakeImageHandleResidentNV (GLuint64 handle, GLenum access);
GLAPI void APIENTRY glMakeImageHandleNonResidentNV (GLuint64 handle);
GLAPI void APIENTRY glUniformHandleui64NV (GLint location, GLuint64 value);
GLAPI void APIENTRY glUniformHandleui64vNV (GLint location, GLsizei count, const GLuint64 *value);
GLAPI void APIENTRY glProgramUniformHandleui64NV (GLuint program, GLint location, GLuint64 value);
GLAPI void APIENTRY glProgramUniformHandleui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64 *values);
GLAPI GLboolean APIENTRY glIsTextureHandleResidentNV (GLuint64 handle);
GLAPI GLboolean APIENTRY glIsImageHandleResidentNV (GLuint64 handle);
#endif
#endif /* GL_NV_bindless_texture */

#ifndef GL_NV_blend_equation_advanced
#define GL_NV_blend_equation_advanced 1
#define GL_BLEND_OVERLAP_NV               0x9281
#define GL_BLEND_PREMULTIPLIED_SRC_NV     0x9280
#define GL_BLUE_NV                        0x1905
#define GL_COLORBURN_NV                   0x929A
#define GL_COLORDODGE_NV                  0x9299
#define GL_CONJOINT_NV                    0x9284
#define GL_CONTRAST_NV                    0x92A1
#define GL_DARKEN_NV                      0x9297
#define GL_DIFFERENCE_NV                  0x929E
#define GL_DISJOINT_NV                    0x9283
#define GL_DST_ATOP_NV                    0x928F
#define GL_DST_IN_NV                      0x928B
#define GL_DST_NV                         0x9287
#define GL_DST_OUT_NV                     0x928D
#define GL_DST_OVER_NV                    0x9289
#define GL_EXCLUSION_NV                   0x92A0
#define GL_GREEN_NV                       0x1904
#define GL_HARDLIGHT_NV                   0x929B
#define GL_HARDMIX_NV                     0x92A9
#define GL_HSL_COLOR_NV                   0x92AF
#define GL_HSL_HUE_NV                     0x92AD
#define GL_HSL_LUMINOSITY_NV              0x92B0
#define GL_HSL_SATURATION_NV              0x92AE
#define GL_INVERT_OVG_NV                  0x92B4
#define GL_INVERT_RGB_NV                  0x92A3
#define GL_LIGHTEN_NV                     0x9298
#define GL_LINEARBURN_NV                  0x92A5
#define GL_LINEARDODGE_NV                 0x92A4
#define GL_LINEARLIGHT_NV                 0x92A7
#define GL_MINUS_CLAMPED_NV               0x92B3
#define GL_MINUS_NV                       0x929F
#define GL_MULTIPLY_NV                    0x9294
#define GL_OVERLAY_NV                     0x9296
#define GL_PINLIGHT_NV                    0x92A8
#define GL_PLUS_CLAMPED_ALPHA_NV          0x92B2
#define GL_PLUS_CLAMPED_NV                0x92B1
#define GL_PLUS_DARKER_NV                 0x9292
#define GL_PLUS_NV                        0x9291
#define GL_RED_NV                         0x1903
#define GL_SCREEN_NV                      0x9295
#define GL_SOFTLIGHT_NV                   0x929C
#define GL_SRC_ATOP_NV                    0x928E
#define GL_SRC_IN_NV                      0x928A
#define GL_SRC_NV                         0x9286
#define GL_SRC_OUT_NV                     0x928C
#define GL_SRC_OVER_NV                    0x9288
#define GL_UNCORRELATED_NV                0x9282
#define GL_VIVIDLIGHT_NV                  0x92A6
#define GL_XOR_NV                         0x1506
typedef void (APIENTRYP PFNGLBLENDPARAMETERINVPROC) (GLenum pname, GLint value);
typedef void (APIENTRYP PFNGLBLENDBARRIERNVPROC) (void);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glBlendParameteriNV (GLenum pname, GLint value);
GLAPI void APIENTRY glBlendBarrierNV (void);
#endif
#endif /* GL_NV_blend_equation_advanced */

#ifndef GL_NV_blend_equation_advanced_coherent
#define GL_NV_blend_equation_advanced_coherent 1
#define GL_BLEND_ADVANCED_COHERENT_NV     0x9285
#endif /* GL_NV_blend_equation_advanced_coherent */

#ifndef GL_NV_blend_square
#define GL_NV_blend_square 1
#endif /* GL_NV_blend_square */

#ifndef GL_NV_clip_space_w_scaling
#define GL_NV_clip_space_w_scaling 1
#define GL_VIEWPORT_POSITION_W_SCALE_NV   0x937C
#define GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV 0x937D
#define GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV 0x937E
typedef void (APIENTRYP PFNGLVIEWPORTPOSITIONWSCALENVPROC) (GLuint index, GLfloat xcoeff, GLfloat ycoeff);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glViewportPositionWScaleNV (GLuint index, GLfloat xcoeff, GLfloat ycoeff);
#endif
#endif /* GL_NV_clip_space_w_scaling */

#ifndef GL_NV_command_list
#define GL_NV_command_list 1
#define GL_TERMINATE_SEQUENCE_COMMAND_NV  0x0000
#define GL_NOP_COMMAND_NV                 0x0001
#define GL_DRAW_ELEMENTS_COMMAND_NV       0x0002
#define GL_DRAW_ARRAYS_COMMAND_NV         0x0003
#define GL_DRAW_ELEMENTS_STRIP_COMMAND_NV 0x0004
#define GL_DRAW_ARRAYS_STRIP_COMMAND_NV   0x0005
#define GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV 0x0006
#define GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV 0x0007
#define GL_ELEMENT_ADDRESS_COMMAND_NV     0x0008
#define GL_ATTRIBUTE_ADDRESS_COMMAND_NV   0x0009
#define GL_UNIFORM_ADDRESS_COMMAND_NV     0x000A
#define GL_BLEND_COLOR_COMMAND_NV         0x000B
#define GL_STENCIL_REF_COMMAND_NV         0x000C
#define GL_LINE_WIDTH_COMMAND_NV          0x000D
#define GL_POLYGON_OFFSET_COMMAND_NV      0x000E
#define GL_ALPHA_REF_COMMAND_NV           0x000F
#define GL_VIEWPORT_COMMAND_NV            0x0010
#define GL_SCISSOR_COMMAND_NV             0x0011
#define GL_FRONT_FACE_COMMAND_NV          0x0012
typedef void (APIENTRYP PFNGLCREATESTATESNVPROC) (GLsizei n, GLuint *states);
typedef void (APIENTRYP PFNGLDELETESTATESNVPROC) (GLsizei n, const GLuint *states);
typedef GLboolean (APIENTRYP PFNGLISSTATENVPROC) (GLuint state);
typedef void (APIENTRYP PFNGLSTATECAPTURENVPROC) (GLuint state, GLenum mode);
typedef GLuint (APIENTRYP PFNGLGETCOMMANDHEADERNVPROC) (GLenum tokenID, GLuint size);
typedef GLushort (APIENTRYP PFNGLGETSTAGEINDEXNVPROC) (GLenum shadertype);
typedef void (APIENTRYP PFNGLDRAWCOMMANDSNVPROC) (GLenum primitiveMode, GLuint buffer, const GLintptr *indirects, const GLsizei *sizes, GLuint count);
typedef void (APIENTRYP PFNGLDRAWCOMMANDSADDRESSNVPROC) (GLenum primitiveMode, const GLuint64 *indirects, const GLsizei *sizes, GLuint count);
typedef void (APIENTRYP PFNGLDRAWCOMMANDSSTATESNVPROC) (GLuint buffer, const GLintptr *indirects, const GLsizei *sizes, const GLuint *states, const GLuint *fbos, GLuint count);
typedef void (APIENTRYP PFNGLDRAWCOMMANDSSTATESADDRESSNVPROC) (const GLuint64 *indirects, const GLsizei *sizes, const GLuint *states, const GLuint *fbos, GLuint count);
typedef void (APIENTRYP PFNGLCREATECOMMANDLISTSNVPROC) (GLsizei n, GLuint *lists);
typedef void (APIENTRYP PFNGLDELETECOMMANDLISTSNVPROC) (GLsizei n, const GLuint *lists);
typedef GLboolean (APIENTRYP PFNGLISCOMMANDLISTNVPROC) (GLuint list);
typedef void (APIENTRYP PFNGLLISTDRAWCOMMANDSSTATESCLIENTNVPROC) (GLuint list, GLuint segment, const void **indirects, const GLsizei *sizes, const GLuint *states, const GLuint *fbos, GLuint count);
typedef void (APIENTRYP PFNGLCOMMANDLISTSEGMENTSNVPROC) (GLuint list, GLuint segments);
typedef void (APIENTRYP PFNGLCOMPILECOMMANDLISTNVPROC) (GLuint list);
typedef void (APIENTRYP PFNGLCALLCOMMANDLISTNVPROC) (GLuint list);
#ifdef GL_GLEXT_PROTOTYPES
GLAPI void APIENTRY glCreateStatesNV (GLsizei n, GLuint *states);
GLAPI void APIENTRY glDeleteStatesNV (GLsizei n, const GLuint *states);
GLAPI GLboolean APIENTRY glIsStateNV (GLuint state);
GLAPI void APIENTRY glStateCaptureNV (GLuint state, GLenum mode);
GLAPI GLuint APIENTRY glGetCommandHeaderNV (GLenum tokenID, GLuint size);
GLAPI GLushort APIENTRY glGetStageIndexNV (GLenum shadertype);
GLAPI void APIENTRY glDrawCommandsNV (GLenum primitiveMode, GLuint buffer, const GLintptr *indirects, const GLsizei *sizes, GLuint count);
GLAPI void APIENTRY glDrawCommandsAddressNV (GLenum primitiveMode, const GLuint64 *indirects, const GLsizei *sizes, GLuint count);
GLAPI void APIENTRY glDrawCommandsStatesNV (GLuint buffer, const GLintptr *indirects, const GLsizei *sizes, const GLuint *states, const GLuint *fbos, GLuint count);
GLAPI void APIENTRY glDrawCommandsStatesAddressNV (const GLuint64 *indirects, const GLsizei *sizes, const GLuint *states, const GLuint *fbos, GLuint count);
GLAPI void APIENTRY glCreateCommandList