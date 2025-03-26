<h1 class="" data-start="61" data-end="123"><strong data-start="63" data-end="118">OOP Principles in Unity – A Practical Guide with C#</strong> 🎮</h1>
<h2 class="" data-start="125" data-end="142"><strong data-start="128" data-end="140">Overview</strong></h2>
<p class="" data-start="143" data-end="502">This project is built in <strong data-start="168" data-end="177">Unity</strong> and demonstrates <strong data-start="195" data-end="243">Object-Oriented Programming (OOP) principles</strong> using <strong data-start="250" data-end="264">C# scripts</strong>. Each <strong data-start="271" data-end="286">OOP concept</strong> (Encapsulation, Abstraction, Inheritance, and Polymorphism) is explained through practical <strong data-start="378" data-end="410">examples in the Unity Editor</strong>, helping developers understand how to apply OOP in real-world <strong data-start="473" data-end="499">Unity game development</strong>.</p>

<h2 class="" data-start="504" data-end="533"><strong data-start="507" data-end="531">OOP Concepts Covered</strong></h2>
<h3 class="" data-start="535" data-end="564"><strong data-start="539" data-end="562">1. Encapsulation 🔒</strong></h3>
<p class="" data-start="565" data-end="690"><strong data-start="565" data-end="579">Definition</strong>: Encapsulation restricts direct access to data and ensures that it is modified through well-defined methods.</p>
<p class="" data-start="692" data-end="715"><strong data-start="692" data-end="713">Example in Unity:</strong></p>

<ul data-start="716" data-end="870">
 	<li class="" data-start="716" data-end="805">
<p class="" data-start="718" data-end="805">The <strong data-start="722" data-end="732">Player</strong> class has private health variables with public methods to update them.</p>
</li>
 	<li class="" data-start="806" data-end="870">
<p class="" data-start="808" data-end="870">Prevents direct modifications and ensures controlled access.</p>
</li>
</ul>
<div class="contain-inline-size rounded-md border-[0.5px] border-token-border-medium relative bg-token-sidebar-surface-primary">
<div class="flex items-center text-token-text-secondary px-4 py-2 text-xs font-sans justify-between h-9 bg-token-sidebar-surface-primary dark:bg-token-main-surface-secondary select-none rounded-t-[5px]">csharp</div>
<div class="sticky top-9">
<div class="absolute bottom-0 right-0 flex h-9 items-center pr-2">
<div class="flex items-center rounded bg-token-sidebar-surface-primary px-2 font-sans text-xs text-token-text-secondary dark:bg-token-main-surface-secondary"><span class="" data-state="closed"><button class="flex gap-1 items-center select-none px-4 py-1" aria-label="Copy">Copy</button></span><span class="" data-state="closed"><button class="flex select-none items-center gap-1 px-4 py-1">Edit</button></span></div>
</div>
</div>
<div class="overflow-y-auto p-4" dir="ltr"><code class="!whitespace-pre language-csharp"><code class="!whitespace-pre language-csharp"><span class="hljs-keyword">public</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Player</span> : <span class="hljs-title">MonoBehaviour</span>
{
<span class="hljs-keyword">private</span> <span class="hljs-built_in">int</span> health = <span class="hljs-number">100</span>;</code></code><span class="hljs-function"><span class="hljs-keyword">public</span></span> <span class="hljs-keyword">void</span> <span class="hljs-title">TakeDamage</span>(<span class="hljs-params"><span class="hljs-built_in">int</span></span> damage)
{
health -= damage;
Debug.Log(<span class="hljs-string">"Player Health: "</span> + health);
}
}

</div>
</div>

<hr class="" data-start="1082" data-end="1085" />

<h3 class="" data-start="1087" data-end="1114"><strong data-start="1091" data-end="1112">2. Abstraction 🎭</strong></h3>
<p class="" data-start="1115" data-end="1228"><strong data-start="1115" data-end="1129">Definition</strong>: Abstraction hides complex details and provides a simple interface for interacting with objects.</p>
<p class="" data-start="1230" data-end="1253"><strong data-start="1230" data-end="1251">Example in Unity:</strong></p>

<ul data-start="1254" data-end="1381">
 	<li class="" data-start="1254" data-end="1381">
<p class="" data-start="1256" data-end="1381">The <code data-start="1260" data-end="1268">Weapon</code> class defines an abstract method <code data-start="1302" data-end="1312">Attack()</code>, which is implemented differently in <code data-start="1350" data-end="1355">Gun</code> and <code data-start="1360" data-end="1367">Sword</code> subclasses.</p>
</li>
</ul>
<div class="contain-inline-size rounded-md border-[0.5px] border-token-border-medium relative bg-token-sidebar-surface-primary">
<div class="flex items-center text-token-text-secondary px-4 py-2 text-xs font-sans justify-between h-9 bg-token-sidebar-surface-primary dark:bg-token-main-surface-secondary select-none rounded-t-[5px]">csharp</div>
<div class="sticky top-9">
<div class="absolute bottom-0 right-0 flex h-9 items-center pr-2">
<div class="flex items-center rounded bg-token-sidebar-surface-primary px-2 font-sans text-xs text-token-text-secondary dark:bg-token-main-surface-secondary"><span class="" data-state="closed"><button class="flex gap-1 items-center select-none px-4 py-1" aria-label="Copy">Copy</button></span><span class="" data-state="closed"><button class="flex select-none items-center gap-1 px-4 py-1">Edit</button></span></div>
</div>
</div>
<div class="overflow-y-auto p-4" dir="ltr"><code class="!whitespace-pre language-csharp"><code class="!whitespace-pre language-csharp"><span class="hljs-keyword">public</span> <span class="hljs-keyword">abstract</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Weapon</span> : <span class="hljs-title">MonoBehaviour</span>
{
<span class="hljs-function"><span class="hljs-keyword">public</span></span> <span class="hljs-keyword">abstract</span> <span class="hljs-keyword">void</span> <span class="hljs-title">Attack</span>();
}</code></code><span class="hljs-keyword">public</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Gun</span> : <span class="hljs-title">Weapon</span>
{
<span class="hljs-function"><span class="hljs-keyword">public</span></span> <span class="hljs-keyword">override</span> <span class="hljs-keyword">void</span> <span class="hljs-title">Attack</span>()
{
Debug.Log(<span class="hljs-string">"Shooting with gun!"</span>);
}
}

<code class="!whitespace-pre language-csharp"><code class="!whitespace-pre language-csharp"></code></code><span class="hljs-keyword">public</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Sword</span> : <span class="hljs-title">Weapon</span>
{
<span class="hljs-function"><span class="hljs-keyword">public</span></span> <span class="hljs-keyword">override</span> <span class="hljs-keyword">void</span> <span class="hljs-title">Attack</span>()
{
Debug.Log(<span class="hljs-string">"Swinging sword!"</span>);
}
}

</div>
</div>

<hr class="" data-start="1717" data-end="1720" />

<h3 class="" data-start="1722" data-end="1749"><strong data-start="1726" data-end="1747">3. Inheritance 🧬</strong></h3>
<p class="" data-start="1750" data-end="1849"><strong data-start="1750" data-end="1764">Definition</strong>: Inheritance allows a class to derive properties and behaviors from another class.</p>
<p class="" data-start="1851" data-end="1874"><strong data-start="1851" data-end="1872">Example in Unity:</strong></p>

<ul data-start="1875" data-end="1997">
 	<li class="" data-start="1875" data-end="1997">
<p class="" data-start="1877" data-end="1997"><code data-start="1877" data-end="1884">Enemy</code> is a base class, and <code data-start="1906" data-end="1914">Zombie</code> and <code data-start="1919" data-end="1926">Robot</code> inherit from it, reusing common properties like health and movement.</p>
</li>
</ul>
<div class="contain-inline-size rounded-md border-[0.5px] border-token-border-medium relative bg-token-sidebar-surface-primary">
<div class="flex items-center text-token-text-secondary px-4 py-2 text-xs font-sans justify-between h-9 bg-token-sidebar-surface-primary dark:bg-token-main-surface-secondary select-none rounded-t-[5px]">csharp</div>
<div class="sticky top-9">
<div class="absolute bottom-0 right-0 flex h-9 items-center pr-2">
<div class="flex items-center rounded bg-token-sidebar-surface-primary px-2 font-sans text-xs text-token-text-secondary dark:bg-token-main-surface-secondary"><span class="" data-state="closed"><button class="flex gap-1 items-center select-none px-4 py-1" aria-label="Copy">Copy</button></span><span class="" data-state="closed"><button class="flex select-none items-center gap-1 px-4 py-1">Edit</button></span></div>
</div>
</div>
<div class="overflow-y-auto p-4" dir="ltr"><code class="!whitespace-pre language-csharp"><code class="!whitespace-pre language-csharp"><span class="hljs-keyword">public</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Enemy</span> : <span class="hljs-title">MonoBehaviour</span>
{
<span class="hljs-keyword">public</span> <span class="hljs-built_in">int</span> health = <span class="hljs-number">100</span>;</code></code><span class="hljs-function"><span class="hljs-keyword">public</span></span> <span class="hljs-keyword">void</span> <span class="hljs-title">TakeDamage</span>(<span class="hljs-params"><span class="hljs-built_in">int</span></span> damage)
{
health -= damage;
Debug.Log(<span class="hljs-string">"Enemy Health: "</span> + health);
}
}

<code class="!whitespace-pre language-csharp"><code class="!whitespace-pre language-csharp"></code></code><span class="hljs-keyword">public</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Zombie</span> : <span class="hljs-title">Enemy</span>
{
<span class="hljs-function"><span class="hljs-keyword">void</span></span> <span class="hljs-title">Start</span>()
{
Debug.Log(<span class="hljs-string">"Zombie spawned with "</span> + health + <span class="hljs-string">" health."</span>);
}
}

<code class="!whitespace-pre language-csharp"><code class="!whitespace-pre language-csharp"></code></code><span class="hljs-keyword">public</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Robot</span> : <span class="hljs-title">Enemy</span>
{
<span class="hljs-function"><span class="hljs-keyword">void</span></span> <span class="hljs-title">Start</span>()
{
Debug.Log(<span class="hljs-string">"Robot activated with "</span> + health + <span class="hljs-string">" health."</span>);
}
}

</div>
</div>

<hr class="" data-start="2460" data-end="2463" />

<h3 class="" data-start="2465" data-end="2495"><strong data-start="2469" data-end="2493">4. Polymorphism 🎭🔄</strong></h3>
<p class="" data-start="2496" data-end="2610"><strong data-start="2496" data-end="2510">Definition</strong>: Polymorphism allows methods to be overridden or used interchangeably through a common interface.</p>
<p class="" data-start="2612" data-end="2635"><strong data-start="2612" data-end="2633">Example in Unity:</strong></p>

<ul data-start="2636" data-end="2747">
 	<li class="" data-start="2636" data-end="2747">
<p class="" data-start="2638" data-end="2747">The <code data-start="2642" data-end="2649">Enemy</code> class has a virtual method <code data-start="2677" data-end="2687">Attack()</code>, which is <strong data-start="2698" data-end="2712">overridden</strong> by <code data-start="2716" data-end="2724">Zombie</code> and <code data-start="2729" data-end="2736">Robot</code> classes.</p>
</li>
</ul>
<div class="contain-inline-size rounded-md border-[0.5px] border-token-border-medium relative bg-token-sidebar-surface-primary">
<div class="flex items-center text-token-text-secondary px-4 py-2 text-xs font-sans justify-between h-9 bg-token-sidebar-surface-primary dark:bg-token-main-surface-secondary select-none rounded-t-[5px]">csharp</div>
<div class="sticky top-9">
<div class="absolute bottom-0 right-0 flex h-9 items-center pr-2">
<div class="flex items-center rounded bg-token-sidebar-surface-primary px-2 font-sans text-xs text-token-text-secondary dark:bg-token-main-surface-secondary"><span class="" data-state="closed"><button class="flex gap-1 items-center select-none px-4 py-1" aria-label="Copy">Copy</button></span><span class="" data-state="closed"><button class="flex select-none items-center gap-1 px-4 py-1">Edit</button></span></div>
</div>
</div>
<div class="overflow-y-auto p-4" dir="ltr"><code class="!whitespace-pre language-csharp"><code class="!whitespace-pre language-csharp"><span class="hljs-keyword">public</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Enemy</span> : <span class="hljs-title">MonoBehaviour</span>
{
<span class="hljs-function"><span class="hljs-keyword">public</span></span> <span class="hljs-keyword">virtual</span> <span class="hljs-keyword">void</span> <span class="hljs-title">Attack</span>()
{
Debug.Log(<span class="hljs-string">"Enemy attacks!"</span>);
}
}</code></code><span class="hljs-keyword">public</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Zombie</span> : <span class="hljs-title">Enemy</span>
{
<span class="hljs-function"><span class="hljs-keyword">public</span></span> <span class="hljs-keyword">override</span> <span class="hljs-keyword">void</span> <span class="hljs-title">Attack</span>()
{
Debug.Log(<span class="hljs-string">"Zombie bites!"</span>);
}
}

<code class="!whitespace-pre language-csharp"><code class="!whitespace-pre language-csharp"></code></code><span class="hljs-keyword">public</span> <span class="hljs-keyword">class</span> <span class="hljs-title">Robot</span> : <span class="hljs-title">Enemy</span>
{
<span class="hljs-function"><span class="hljs-keyword">public</span></span> <span class="hljs-keyword">override</span> <span class="hljs-keyword">void</span> <span class="hljs-title">Attack</span>()
{
Debug.Log(<span class="hljs-string">"Robot fires laser!"</span>);
}
}

</div>
</div>

<hr class="" data-start="3119" data-end="3122" />

<h2 class="" data-start="3124" data-end="3156"><strong data-start="3127" data-end="3154">How to Use This Project</strong></h2>
<ol data-start="3157" data-end="3614">
 	<li class="" data-start="3157" data-end="3287">
<p class="" data-start="3160" data-end="3186"><strong data-start="3160" data-end="3184">Clone the Repository</strong></p>

<div class="contain-inline-size rounded-md border-[0.5px] border-token-border-medium relative bg-token-sidebar-surface-primary">
<div class="flex items-center text-token-text-secondary px-4 py-2 text-xs font-sans justify-between h-9 bg-token-sidebar-surface-primary dark:bg-token-main-surface-secondary select-none rounded-t-[5px]">sh</div>
<div class="sticky top-9">
<div class="absolute bottom-0 right-0 flex h-9 items-center pr-2">
<div class="flex items-center rounded bg-token-sidebar-surface-primary px-2 font-sans text-xs text-token-text-secondary dark:bg-token-main-surface-secondary"><span class="" data-state="closed"><button class="flex gap-1 items-center select-none px-4 py-1" aria-label="Copy">Copy</button></span><span class="" data-state="closed"><button class="flex select-none items-center gap-1 px-4 py-1">Edit</button></span></div>
</div>
</div>
<div class="overflow-y-auto p-4" dir="ltr"><code class="!whitespace-pre language-sh">git <span class="hljs-built_in">clone</span> https://github.com/yourusername/OOP-Unity-Game.git
<span class="hljs-built_in">cd</span> OOP-Unity-Game
</code></div>
</div></li>
 	<li class="" data-start="3288" data-end="3399">
<p class="" data-start="3291" data-end="3310"><strong data-start="3291" data-end="3308">Open in Unity</strong></p>

<ul data-start="3314" data-end="3399">
 	<li class="" data-start="3314" data-end="3366">
<p class="" data-start="3316" data-end="3366">Open <strong data-start="3321" data-end="3334">Unity Hub</strong> and select <strong data-start="3346" data-end="3363">"Add Project"</strong>.</p>
</li>
 	<li class="" data-start="3370" data-end="3399">
<p class="" data-start="3372" data-end="3399">Choose the cloned folder.</p>
</li>
</ul>
</li>
 	<li class="" data-start="3400" data-end="3486">
<p class="" data-start="3403" data-end="3422"><strong data-start="3403" data-end="3420">Run the Scene</strong></p>

<ul data-start="3426" data-end="3486">
 	<li class="" data-start="3426" data-end="3486">
<p class="" data-start="3428" data-end="3486">Press <strong data-start="3434" data-end="3442">Play</strong> in Unity to see OOP principles in action.</p>
</li>
</ul>
</li>
 	<li class="" data-start="3487" data-end="3614">
<p class="" data-start="3490" data-end="3515"><strong data-start="3490" data-end="3513">Modify &amp; Experiment</strong></p>

<ul data-start="3519" data-end="3614">
 	<li class="" data-start="3519" data-end="3614">
<p class="" data-start="3521" data-end="3614">Try adding new <strong data-start="3536" data-end="3551">enemy types</strong>, <strong data-start="3553" data-end="3564">weapons</strong>, or <strong data-start="3569" data-end="3592">extending behaviors</strong> using OOP concepts.</p>
</li>
</ul>
</li>
</ol>

<hr class="" data-start="3616" data-end="3619" />

<h2 class="" data-start="3621" data-end="3642"><strong data-start="3624" data-end="3640">Contributing</strong></h2>
<p class="" data-start="3643" data-end="3783">Feel free to <strong data-start="3656" data-end="3664">fork</strong> this repository and contribute improvements! Submit a <strong data-start="3719" data-end="3735">pull request</strong> if you have enhancements or new OOP examples.</p>


<hr class="" data-start="3785" data-end="3788" />

<h2 class="" data-start="3790" data-end="3806"><strong data-start="3793" data-end="3804">License</strong></h2>
<p class="" data-start="3807" data-end="3867">This project is <strong data-start="3823" data-end="3838">open-source</strong> under the <strong data-start="3849" data-end="3864">MIT License</strong>.</p>


<hr class="" data-start="3869" data-end="3872" />

<h3 class="" data-start="3874" data-end="3918"><strong data-start="3878" data-end="3916">📢 Follow for More Unity Projects!</strong></h3>
<p class="" data-start="3919" data-end="4101">
🔹 <strong>GitHub</strong>: https://github.com/alokkrishali
🔹 <strong>Facebook</strong>: https://www.facebook.com/learngamestutorial
🔹 <strong>Youtube</strong>: https://www.youtube.com/@LearnGamesTutorial
🔹 <strong>Blog</strong>: <a href="https://learngamestutorial.com/">Learn games tutorial</a></p>


<hr class="" data-start="4103" data-end="4106" />
<p class="" data-start="4108" data-end="4305">This <strong data-start="4113" data-end="4126">README.md</strong> is <strong data-start="4130" data-end="4147">SEO-optimized</strong> with relevant <strong data-start="4162" data-end="4193">Unity, OOP, and C# keywords</strong> to help your GitHub project <strong data-start="4222" data-end="4237">rank better</strong> in search results! 🚀 Let me know if you want any modifications. 😊</p>
