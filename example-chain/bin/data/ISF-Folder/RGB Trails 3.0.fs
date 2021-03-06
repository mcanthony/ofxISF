/*{
	"CREDIT": "by zoidberg",
	"DESCRIPTION": "a persistent buffer is used to maintain an image which is constantly updated.  Similar to VVMotionBlur, but each channel has its own weight",
	"CATEGORIES": [
		"Color Effect"
	],
	"INPUTS": [
		{
			"NAME": "inputImage",
			"TYPE": "image"
		},
		{
			"NAME": "rWeight",
			"TYPE": "float"
		},
		{
			"NAME": "gWeight",
			"TYPE": "float"
		},
		{
			"NAME": "bWeight",
			"TYPE": "float"
		},
		{
			"NAME": "aWeight",
			"TYPE": "float",
			"DEFAULT": 0.0
		}
	],
	"PERSISTENT_BUFFERS": [
		"accum"
	],
	"PASSES": [
		{
			"TARGET":"accum"
		}
	]
	
}*/

void main()
{
	vec4		freshPixel = IMG_THIS_PIXEL(inputImage);
	vec4		stalePixel = IMG_THIS_PIXEL(accum);
	gl_FragColor = vec4(mix(freshPixel.r,stalePixel.r,rWeight), mix(freshPixel.g,stalePixel.g,gWeight), mix(freshPixel.b,stalePixel.b,bWeight), mix(freshPixel.a,stalePixel.a,aWeight));
}
