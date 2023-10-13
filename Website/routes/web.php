<?php

use App\Http\Controllers\AuthController;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\OpenAIController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/cart', function(){ return view('cart');})->name('cart.index');
Route::get('/', [HomeController::class, 'index'])->name('home.index');
Route::get('/checkout', function(){ return view('checkout');})->name('checkout.index');
Route::get('/register', [AuthController::class, 'registerGet'])->name('register.index');
Route::post('/register', [AuthController::class, 'registerSubmit'])->name('register.post.index');
Route::post('/ai-question', [OpenAIController::class, 'OpenAIChatBot'])->name('sender');