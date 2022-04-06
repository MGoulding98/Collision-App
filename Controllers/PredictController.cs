using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using ProjectDriveSafe.Models;

namespace ProjectDriveSafe.Controllers
{
    public class PredictController : Controller
    {
        private InferenceSession _session;

        public PredictController(InferenceSession session)
        {
            _session = session;
        }

        [HttpPost]
        public IActionResult Severity(PredictData data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });

            Tensor<float> score = result.First().AsTensor<float>();

            var prediction = new Prediction { PredictedValue = score.First() };
            result.Dispose();

            return View(prediction);
        }
    }
}