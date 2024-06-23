/*{
	"DESCRIPTION": "Mirror Image Shader",
	"CREDIT": "St4lV",
	"ISFVSN": "2",
	"CATEGORIES": [
		"Image Effects"
	],
	"INPUTS": [
		{
			"NAME": "inputImage",
			"TYPE": "image"
		},
		{
			"NAME": "mirrorHorizontal",
			"TYPE": "bool",
			"DEFAULT": true
		},
		{
			"NAME": "mirrorVertical",
			"TYPE": "bool",
			"DEFAULT": false
		}
	],
	"PASSES": [
		{
			"TARGET":"bufferVariableNameA",
			"WIDTH": "$WIDTH/16.0",
			"HEIGHT": "$HEIGHT/16.0"
		},
		{
			"DESCRIPTION": "This pass ensures that the output is rendered at the same resolution as the input."
		}
	]
}*/

void main() {
	vec2 uv = isf_FragNormCoord.xy;

	if (mirrorHorizontal) {
		uv.x = 1.0 - uv.x;
	}

	if (mirrorVertical) {
		uv.y = 1.0 - uv.y;
	}

	vec4 inputPixelColor = IMG_NORM_PIXEL(inputImage, uv);
	gl_FragColor = inputPixelColor;
}
